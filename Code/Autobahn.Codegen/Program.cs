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
                var propertytype = string.Empty;
                foreach (var prop in classtype.GetProperties())
                {
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
                        $"{classtype.Name}Id"
                    };
                    if (prop.GetAccessors()[0].IsVirtual)
                    {
                        continue;
                    }

                    if (prop.Name.EndsWith("Id"))
                    {
                        propertytype = Nullable.GetUnderlyingType(prop.PropertyType) != null ? "Guid?" : "Guid";
                    }
                    else
                    {
                        propertytype = Nullable.GetUnderlyingType(prop.PropertyType) != null
                            ? $"{Nullable.GetUnderlyingType(prop.PropertyType)}?"
                            : $"{prop.PropertyType}";
                    }

                    var existing = cedsElementsMetadata.FirstOrDefault(t => t.TechnicalName == prop.Name);
                    if (model == null)
                    {
                        if (propertiesToIgnore.Contains(prop.Name))
                        {
                            continue;
                        }
                        var item = new AutobahnTable
                        {
                            TableName = classtype.Name,
                            ColumnName = prop.Name,
                            GlobalId = existing?.GlobalID,
                            ColumnType = propertytype,
                            Version = "--dbtable--"
                        };
                        autobahnTables.Add(item);
                    }
                    else
                    {
                        model.ColumnType = propertytype;
                        model.Id = Guid.NewGuid();
                    }
                }
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
                if (table.TableName.StartsWith("Ae")
                    || table.TableName.EndsWith("AE"))
                {
                    table.AutobahnDomainId = aedom?.Id;
                }
                if (table.TableName.StartsWith("EL")
                    || table.TableName.StartsWith("EarlyChildhood")
                    || table.TableName.EndsWith("EL"))
                {
                    table.AutobahnDomainId = eldom?.Id;
                }
                if (table.TableName.StartsWith("Assessment")
                    || table.TableName.StartsWith("Rubric")
                    || table.TableName.StartsWith("Goal")
                    || table.TableName.StartsWith("Learner"))
                {
                    table.AutobahnDomainId = assesdom?.Id;
                }
                if (table.TableName.StartsWith("Learning")
                    || table.TableName.StartsWith("Peer"))
                {
                    table.AutobahnDomainId = lrdom?.Id;
                }
                if (table.TableName.StartsWith("K12"))
                {
                    table.AutobahnDomainId = k12dom?.Id;
                }
                if (table.TableName.StartsWith("Build")
                    || table.TableName.StartsWith("Facility"))
                {
                    table.AutobahnDomainId = facdom?.Id;
                }
                if (table.TableName.StartsWith("Ps")
                    || table.TableName.StartsWith("PS")
                    || table.TableName.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1)
                {
                    table.AutobahnDomainId = psdom?.Id;
                }
                if (table.TableName.StartsWith("Competency"))
                {
                    table.AutobahnDomainId = compdom?.Id;
                }
                if (table.TableName.StartsWith("Credential"))
                {
                    table.AutobahnDomainId = creddom?.Id;
                }
                if (table.TableName.StartsWith("Cte")
                    || table.TableName.EndsWith("Cte"))
                {
                    table.AutobahnDomainId = ctedom?.Id;
                }
                if (table.TableName.StartsWith("Organization")
                    || table.TableName.StartsWith("Person")
                    || table.TableName.StartsWith("Staff")
                    || table.TableName.StartsWith("Teacher")
                    || table.TableName.StartsWith("Role"))
                {
                    table.AutobahnDomainId = comdom?.Id;
                }
                if (table.TableName.StartsWith("App")
                    || table.TableName.StartsWith("Auth"))
                {
                    table.AutobahnDomainId = authdom?.Id;
                }
                if (table.TableName.StartsWith("Workforce"))
                {
                    table.AutobahnDomainId = wfdom?.Id;
                }
                table.AutobahnDomainId ??= invaliddom?.Id;
            }

            foreach (var table in autobahnTables)
            {
                var dom = autobahnDomains.FirstOrDefault(d => d?.Id == table.AutobahnDomainId);
                table.ModuleName = dom?.Module;
                table.Id ??= Guid.NewGuid();
            }

            foreach (var item in types.GetTypes())
            {
                foreach (var prop in item.GetProperties())
                {
                    if (prop.Name.StartsWith("Ref"))
                    {
                        var reftable = autobahnTables.FirstOrDefault(t =>
                            t.TableName == prop.Name.Replace("Id", string.Empty) && string.IsNullOrEmpty(t.ColumnName));
                        var dom = autobahnTables.FirstOrDefault(t => t.TableName == item.Name && t.ColumnName == prop.Name);
                        if (reftable?.AutobahnDomainId != null)
                        {
                            reftable.AutobahnDomainId = dom?.AutobahnDomainId;
                            reftable.ModuleName = dom?.ModuleName;
                        }
                        if (reftable?.AutobahnDomainId != dom?.AutobahnDomainId)
                        {
                            if (reftable != null)
                            {
                                reftable.AutobahnDomainId = comdom?.Id;
                                reftable.ModuleName = comdom?.Module;
                            }
                        }
                    }
                }
            }

            // Write the updated table file
            csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", autobahnTables, true, ",");

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

                    var tableMeta = tables.FirstOrDefault(t => t.TableName == model.Name && t.ColumnName == prop.Name);
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
                        tableMeta = tables.FirstOrDefault(t => t.TableName == propAsTable
                                                               && t.ColumnName == null);
                    }
                    var autobahnElement = autobahnElements.FirstOrDefault(e => e.TechnicalName == propName);
                    if (autobahnElement != null  
                        && !autobahnElement.AutobahnDomainList.Contains(tableMeta?.AutobahnDomainId))
                    {
                        autobahnElement.AutobahnDomainList.Add(tableMeta?.AutobahnDomainId);
                    }
                    if (autobahnElement != null
                        && !autobahnElement.AutobahnTableList.Contains(tableMeta?.AutobahnDomainId))
                    {
                        autobahnElement?.AutobahnTableList.Add(tableMeta?.Id);
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

            MauiModule.GenerateModule(autobahnDomains, autobahnTables, autobahnElements, types.GetTypes().ToList());
        }
    }
}
