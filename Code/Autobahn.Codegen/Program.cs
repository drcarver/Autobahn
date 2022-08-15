using Autobahn.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace AutobahnCodeGen
{
    internal class Program
    {
        /// <summary>
        /// Return the list of autobahn domains
        /// </summary>
        /// <returns>Return the list of Autobahn domains</returns>
        private static List<AutobahnDomain> GetAutobahnDomains()
        {
            var csv = new CSVServices();
            return csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
        }

        /// <summary>
        /// Return the list of autobahn tables
        /// </summary>
        /// <returns>Return the list of Autobahn tables</returns>
        private static List<AutobahnTable> GetAutobahnTables(Assembly types, List<AutobahnDomain> autobahnDomains)
        {
            var csv = new CSVServices();
            var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv");
            var cedsElementsMetadata = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");

            //Add any missing classes and columns from the entities
            foreach (var classtype in types.GetTypes())
            {
                if (!classtype.IsClass)
                {
                    continue;
                }

                var tableName = classtype.GetCustomAttributes<TableAttribute>().First();
                AutobahnTable? model = autobahnTables.FirstOrDefault(t => t.TableName == tableName?.Name);
                if (model == null)
                {
                    foreach (var prop in classtype.GetProperties())
                    {
                        if (prop.GetAccessors()[0].IsVirtual)
                        {
                            continue;
                        }

                        var existing = cedsElementsMetadata.FirstOrDefault(t => t.TechnicalName == prop.Name);
                        var item = new AutobahnTable
                        {
                            ModelName = classtype.Name,
                            ColumnName = prop.Name,
                            GlobalId = existing?.GlobalID,
                            Version = "--dbtable--"
                        };
                        item.TableName = item.ModelName;
                        autobahnTables.Add(item);
                    }
                }
                else
                {
                    model.ModelName = classtype.Name;
                }
            }

            var addedcnt = autobahnTables.Count(t => t.Version == "--dbtable--");

            var cnt = autobahnTables.Count(t => t.TableName != t.ModelName);

            // reset the model name to the table name when they are not
            foreach (var item in autobahnTables.Where(t => t.TableName != t.ModelName).ToList())
            {
                item.ModelName = item.TableName;
            }

            // Set the domains in the tablesMetadata
            var comdom = autobahnDomains.First(d => d.Module == "Common");
            var assesdom = autobahnDomains.First(d => d.Module == "Assessments");
            var aedom = autobahnDomains.First(d => d.Module == "AdultEducation");
            var eldom = autobahnDomains.First(d => d.Module == "EarlyLearning");
            var lrdom = autobahnDomains.First(d => d.Module == "LearningResources");
            var k12dom = autobahnDomains.First(d => d.Module == "K12");
            var facdom = autobahnDomains.First(d => d.Module == "Facilities");
            var psdom = autobahnDomains.First(d => d.Module == "Postsecondary");
            var compdom = autobahnDomains.First(d => d.Module == "Competencies");
            var creddom = autobahnDomains.First(d => d.Module == "Credentials");
            var ctedom = autobahnDomains.First(d => d.Module == "CTE");
            var authdom = autobahnDomains.First(d => d.Module == "Authorization");
            var wfdom = autobahnDomains.First(d => d.Module == "Workforce");
            var invaliddom = autobahnDomains.First(d => d.Module == "Invalid");
            foreach (var table in autobahnTables)
            {
                if (table.ModelName.StartsWith("Ae")
                    || table.ModelName.EndsWith("AE"))
                {
                    table.AutobahnDomainId = aedom?.Id;
                }
                if (table.ModelName.StartsWith("EL")
                    || table.ModelName.StartsWith("EarlyChildhood")
                    || table.ModelName.EndsWith("EL"))
                {
                    table.AutobahnDomainId = eldom?.Id;
                }
                if (table.ModelName.StartsWith("Assessment")
                    || table.ModelName.StartsWith("Rubric")
                    || table.ModelName.StartsWith("Goal")
                    || table.ModelName.StartsWith("Learner"))
                {
                    table.AutobahnDomainId = assesdom?.Id;
                }
                if (table.ModelName.StartsWith("Learning")
                    || table.ModelName.StartsWith("Peer"))
                {
                    table.AutobahnDomainId = lrdom?.Id;
                }
                if (table.ModelName.StartsWith("K12"))
                {
                    table.AutobahnDomainId = k12dom?.Id;
                }
                if (table.ModelName.StartsWith("Build")
                    || table.ModelName.StartsWith("Facility"))
                {
                    table.AutobahnDomainId = facdom?.Id;
                }
                if (table.ModelName.StartsWith("Ps")
                    || table.ModelName.StartsWith("PS"))
                {
                    table.AutobahnDomainId = psdom?.Id;
                }
                if (table.ModelName.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1)
                {
                    table.AutobahnDomainId = psdom?.Id;
                }
                if (table.ModelName.StartsWith("Competency"))
                {
                    table.AutobahnDomainId = compdom?.Id;
                }
                if (table.ModelName.StartsWith("Credential"))
                {
                    table.AutobahnDomainId = creddom?.Id;
                }
                if (table.ModelName.StartsWith("Cte")
                    || table.ModelName.EndsWith("Cte"))
                {
                    table.AutobahnDomainId = ctedom?.Id;
                }
                if (table.ModelName.StartsWith("Organization")
                    || table.ModelName.StartsWith("Person")
                    || table.ModelName.StartsWith("Staff")
                    || table.ModelName.StartsWith("Teacher")
                    || table.ModelName.StartsWith("Role"))
                {
                    table.AutobahnDomainId = comdom?.Id;
                }
                if (table.ModelName.StartsWith("App")
                    || table.ModelName.StartsWith("Auth"))
                {
                    table.AutobahnDomainId = authdom?.Id;
                }
                if (table.ModelName.StartsWith("Workforce"))
                {
                    table.AutobahnDomainId = wfdom?.Id;
                }
                table.AutobahnDomainId ??= invaliddom?.Id;
            }

            // Write the updated table file
            csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", autobahnTables);

            return autobahnTables;
        }

        private static List<AutobahnElement> GetAutobahnElements(List<AutobahnDomain> domains,  List<AutobahnTable> tables, Assembly types)
        {
            var csv = new CSVServices();
            var CEDSElements = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
            var autobahnElements = new List<AutobahnElement>();

            // create a lookup table of models to properties
            foreach (var model in types.GetTypes().ToList())
            {
                if (!model.IsClass)
                {
                    continue;
                }

                // Copy over the element data
                foreach (var prop in model.GetProperties())
                {
                    CEDSElement? elementMeta;

                    var tableMeta = tables.FirstOrDefault(t => t.ModelName == model.Name && t.ColumnName == prop.Name);
                    List<string> propertiesToIgnore = new List<string>
                    {
                        "RecordStartDateTime",
                        "RecordEndDateTime",
                        "RecordStatusId",
                        "Description",
                        "Code",
                        "Definition",
                        "RefJurisdictionId",
                        "SortOrder",
                        "DataCollectionId",
                        $"{model.Name}Id"
                    };

                    // no virtual properties.  We will handle those later as service calls
                    if (propertiesToIgnore.Contains(prop.Name)
                        || prop.GetAccessors()[0].IsVirtual)
                    {
                        continue;
                    }

                    var propName = prop.Name;
                    if (tableMeta == null)
                    {
                        string propAsTable = propName;
                        if (propName.EndsWith("Id"))
                        {
                            propAsTable = propName.Replace("Id", String.Empty);
                        }
                        tableMeta = tables.FirstOrDefault(t => t.ModelName == propAsTable
                                                               && t.ColumnName == null);
                    }
                    string propertype = string.Empty;
                    if (propName.EndsWith("Id"))
                    {
                        propertype = Nullable.GetUnderlyingType(prop.PropertyType) != null ? "Guid?" : "Guid";
                    }
                    else
                    {
                        propertype = Nullable.GetUnderlyingType(prop.PropertyType) != null 
                            ? $"{Nullable.GetUnderlyingType(prop.PropertyType)}?" 
                            : $"{prop.PropertyType}";
                    }
                    elementMeta = CEDSElements.FirstOrDefault(e => e.GlobalID == tableMeta?.GlobalId) 
                                  ?? CEDSElements.FirstOrDefault(e => e.TechnicalName == prop.Name);
                    var autobahnElement = autobahnElements.FirstOrDefault(e => e.TechnicalName == propName);
                    if (autobahnElement == null)
                    {
                        autobahnElement = new AutobahnElement
                        {
                            PropertyType = propertype,
                            TechnicalName = propName,
                            AltName = elementMeta?.AlternateName,
                            ChangeNotes = elementMeta?.ChangeNotes,
                            Definition = elementMeta?.Definition,
                            ElementName = elementMeta?.ElementName,
                            Format = elementMeta?.Format,
                            GlobalId = elementMeta?.TechnicalName == null ? null : elementMeta?.GlobalID,
                            HasOptionSet = elementMeta?.OptionSet,
                            TermID = elementMeta?.TermId,
                            URL = elementMeta?.URL,
                            UsageNotes = elementMeta?.UsageNotes,
                            Version = elementMeta?.Version,
                            IsVirtual = prop.GetAccessors()[0].IsVirtual
                        };
                        autobahnElements.Add(autobahnElement);
                    }
                    if (!autobahnElement.AutobahnDomainList.Contains(tableMeta?.AutobahnDomainId))
                    {
                        autobahnElement.AutobahnDomainList.Add(tableMeta?.AutobahnDomainId);
                    }
                    if (!autobahnElement.AutobahnTableList.Contains(tableMeta?.Id))
                    {
                        autobahnElement.AutobahnTableList.Add(tableMeta?.Id);
                    }
                }
            }

            var comdom = domains.First(d => d.Module == "Common");
            foreach (var element in autobahnElements)
            {
                if (element.AutobahnDomainList.Count > 1)
                {
                    element.AutobahnDomainList.Clear();
                    element.AutobahnDomainList.Add(comdom.Id);
                }
            }

            // save off the updated elements
            csv.WriteAutobahnElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv", autobahnElements);

            return autobahnElements;
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<ModelProperty>> ModelProperties = new Dictionary<string, List<ModelProperty>>();
            var csv = new CSVServices();
            var types = Assembly.Load(typeof(Autobahn.Entities.Activity).Assembly.FullName);
            var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
            var autobahnTables = GetAutobahnTables(types, autobahnDomains);
            var autobahnElements = GetAutobahnElements(autobahnDomains, autobahnTables, types);
            
            var sdcnt = autobahnElements.Count(e => e.AutobahnDomainList.Count == 1);

            var secnt = autobahnElements.Count(e => e.AutobahnTableList.Count == 1);
            var mecnt = autobahnElements.Count(e => e.AutobahnTableList.Count > 1);

            var refcnt = autobahnElements.Count(e => e.TechnicalName.StartsWith("Ref"));
            var refscnt = autobahnElements.Count(e => e.TechnicalName.StartsWith("Ref") && e.AutobahnTableList.Count == 1);
            var refmcnt = autobahnElements.Count(e => e.TechnicalName.StartsWith("Ref") && e.AutobahnTableList.Count > 1);

            MauiModule.GenerateModule(autobahnDomains, autobahnTables, autobahnElements);
        }
    }
}
