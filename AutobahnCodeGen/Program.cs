using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using Autobahn.Entities;

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
                AutobahnTable model = autobahnTables.FirstOrDefault(t => t.TableName == tableName?.Name);
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
                            ModelName = classtype.Name.EndsWith("Statu") ? classtype.Name.Replace("Statu", "Status") : classtype.Name,
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

            foreach (var item in autobahnTables.Where(t => t.TableName != t.ModelName).ToList())
            {
                if (string.IsNullOrEmpty(item.ModelName) && !string.IsNullOrEmpty(item.TableName))
                {
                    item.ModelName = item.TableName;
                }
                if (!string.IsNullOrEmpty(item.ModelName) && string.IsNullOrEmpty(item.TableName))
                {
                    item.TableName = item.ModelName;
                }
            }

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
                    || table.ModelName.StartsWith("EarlyChildhood"))
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
                if (table.AutobahnDomainId == null)
                {
                    table.AutobahnDomainId = invaliddom?.Id;
                }
            }

            // Set the reference to the correct domain
            foreach (var table in autobahnTables.Where(t => t.ModelName.StartsWith("Ref")))
            {
                foreach (var col in autobahnTables.Where(c => c.ColumnName.StartsWith(table.ModelName)))
                {
                    if (table.AutobahnDomainId != col.AutobahnDomainId)
                    {
                        table.AutobahnDomainId = comdom.Id;
                    }
                }
            }

            // Write the updated table file
            csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", autobahnTables);

            return autobahnTables;
        }

        private static List<AutobahnElement> GetAutobahnElements(List<AutobahnTable> tables, Assembly types)
        {
            var csv = new CSVServices();
            var CEDSElements = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
            var autobahnElements = new List<AutobahnElement>();

            // create a lookup table of models to properties
            foreach (var model in types.GetTypes().ToList())
            {
                var modelName = model.Name;
                if (model.Name.EndsWith("Statu"))
                {
                    modelName = modelName.Replace("Statu", "Status");
                }
                var tableMeta = tables.FirstOrDefault(t => t.ModelName == modelName);
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
                    $"{modelName}Id"
                };

                // Copy over the element data
                foreach (var prop in model.GetProperties())
                {
                    CEDSElement elementMeta;
        
                    // no virtual properties.  We will handle those later as service calls
                    if (propertiesToIgnore.Contains(prop.Name))
                    {
                        continue;
                    }
                    var propName = prop.Name;
                    if (prop.Name.EndsWith("Statu"))
                    {
                        propName = propName.Replace("Statu", "Status");
                    }
                    if (tableMeta == null)
                    {
                        string propAsTable = propName;
                        if (propName.EndsWith("Id"))
                        {
                            propAsTable = propName.Replace("Id", String.Empty);
                        }
                        tableMeta = tables.FirstOrDefault(t => t.ModelName == modelName
                                                               && t.ColumnName == propAsTable);
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
                    elementMeta = CEDSElements.FirstOrDefault(e => e.GlobalID == tableMeta?.GlobalId);
                    var autobahnElement = new AutobahnElement
                    {
                        PropertyType = propertype,
                        TechnicalName = propName,
                        AltName = elementMeta?.AlternateName,
                        ChangeNotes = elementMeta?.ChangeNotes,
                        Definition = elementMeta?.Definition,
                        ElementName = elementMeta?.ElementName,
                        Format = elementMeta?.Format,
                        GlobalId = elementMeta?.GlobalID,
                        HasOptionSet = elementMeta?.OptionSet,
                        TermID = elementMeta?.TermId,
                        URL = elementMeta?.URL,
                        UsageNotes = elementMeta?.UsageNotes,
                        Version = elementMeta?.Version,
                        IsVirtual = prop.GetAccessors()[0].IsVirtual
                    };
                    if (!autobahnElement.AutobahnDomainList.Contains(tableMeta?.AutobahnDomainId))
                    {
                        autobahnElement.AutobahnDomainList.Add(tableMeta?.AutobahnDomainId);
                    }
                    if (!autobahnElement.AutobahnTableList.Contains(tableMeta?.Id))
                    {
                        autobahnElement.AutobahnTableList.Add(tableMeta?.Id);
                    }
                    autobahnElements.Add(autobahnElement);
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
            var autobahnElements = GetAutobahnElements(autobahnTables, types);

            MauiModule.GenerateModule(autobahnDomains, autobahnTables, autobahnElements);
        }
    }
}
