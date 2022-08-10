using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using Autobahn.Entities;

namespace AutobahnCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<ModelProperty>> ModelProperties = new Dictionary<string, List<ModelProperty>>();
            var csv = new CEDSService();
            var cedsElementsMetadata = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
            var types = Assembly.Load(typeof(Autobahn.Entities.Activity).Assembly.FullName);
            var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
            var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv");

            //Add any missing clases and columns from the entites
            foreach (var classtype in types.GetTypes().ToList())
            {
                if (!classtype.IsClass
                    || classtype.Name == "C_CEDSElements"
                    || classtype.Name == "C_CEDStoNDSMapping"
                    || classtype.Name.StartsWith("Autobahn"))
                {
                    continue;
                }

                var model = autobahnTables.FirstOrDefault(t => t.ModelName == classtype.Name.Replace("Statu", "Status")) ??
                            autobahnTables.FirstOrDefault(t => t.ModelName == classtype.Name.Replace("Id", string.Empty));
                if (model == null)
                {
                    foreach (var prop in classtype.GetProperties())
                    {
                        if (prop.GetAccessors()[0].IsVirtual)
                        {
                            continue;
                        }

                        var existing = cedsElementsMetadata.FirstOrDefault(t => t.TechnicalName == prop.Name);
                        autobahnTables.Add(new AutobahnTable
                        {
                            ModelName = classtype.Name.EndsWith("Statu") ? classtype.Name.Replace("Statu", "Status") : classtype.Name,
                            ColumnName = prop.Name,
                            GlobalId = existing?.GlobalID,
                            Version = "--dbtable--"
                        });
                    }
                }
            }

            // Set the domains in the tablesMetadata
            var refdom = autobahnDomains.FirstOrDefault(d => d.Module == "Reference");
            var comdom = autobahnDomains.FirstOrDefault(d => d.Module == "Common");
            foreach (var table in autobahnTables)
            {
                var aedom = autobahnDomains.FirstOrDefault(d => d.Module == "AdultEducation");
                if (table.ModelName.StartsWith("Ae")
                    || table.ModelName.EndsWith("AE"))
                {
                    table.AutobahnDomainId = aedom?.Id;
                }
                var eldom = autobahnDomains.FirstOrDefault(d => d.Module == "EarlyLearning");
                if (table.ModelName.StartsWith("EL")
                    || table.ModelName.StartsWith("EarlyChildhood"))
                {
                    table.AutobahnDomainId = eldom?.Id;
                }
                var assesdom = autobahnDomains.FirstOrDefault(d => d.Module == "Assessment");
                if (table.ModelName.StartsWith("Assessment")
                    || table.ModelName.StartsWith("Rubric")
                    || table.ModelName.StartsWith("Goal")
                    || table.ModelName.StartsWith("Learner"))
                {
                    table.AutobahnDomainId = assesdom?.Id;
                }
                var lrdom = autobahnDomains.FirstOrDefault(d => d.Module == "LearningResource");
                if (table.ModelName.StartsWith("Learning")
                    || table.ModelName.StartsWith("Peer"))
                {
                    table.AutobahnDomainId = lrdom?.Id;
                }
                var k12dom = autobahnDomains.FirstOrDefault(d => d.Module == "K12");
                if (table.ModelName.StartsWith("K12"))
                {
                    table.AutobahnDomainId = k12dom?.Id;
                }
                var facdom = autobahnDomains.FirstOrDefault(d => d.Module == "Facilities");
                if (table.ModelName.StartsWith("Build")
                    || table.ModelName.StartsWith("Facility"))
                {
                    table.AutobahnDomainId = facdom?.Id;
                }
                var psdom = autobahnDomains.FirstOrDefault(d => d.Module == "Postsecondary");
                if (table.ModelName.StartsWith("Ps")
                    || table.ModelName.StartsWith("PS")
                    || table.ModelName.IndexOf("IPEDS") > 0)
                {
                    table.AutobahnDomainId = psdom?.Id;
                }
                var compdom = autobahnDomains.FirstOrDefault(d => d.Module == "Competency");
                if (table.ModelName.StartsWith("Competency"))
                {
                    table.AutobahnDomainId = compdom?.Id;
                }
                var creddom = autobahnDomains.FirstOrDefault(d => d.Module == "Credentials");
                if (table.ModelName.StartsWith("Credential"))
                {
                    table.AutobahnDomainId = creddom?.Id;
                }
                var ctedom = autobahnDomains.FirstOrDefault(d => d.Module == "CTE");
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
                var authdom = autobahnDomains.FirstOrDefault(d => d.Module == "Authorization");
                if (table.ModelName.StartsWith("App")
                    || table.ModelName.StartsWith("Auth"))
                {
                    table.AutobahnDomainId = authdom?.Id;
                }
                if (table.ModelName.StartsWith("Ref"))
                {
                    table.AutobahnDomainId = refdom?.Id;
                }
                var wfdom = autobahnDomains.FirstOrDefault(d => d.Module == "Workforce");
                if (table.ModelName.StartsWith("Workforce"))
                {
                    table.AutobahnDomainId = wfdom?.Id;
                }
                if (table.AutobahnDomainId == null)
                {
                    table.AutobahnDomainId = authdom?.Id;
                }
            }

            // Set the reference to the correct domain
            foreach (var table in autobahnTables.Where(t => t.ModelName.StartsWith("Ref")))
            {
                foreach (var col in autobahnTables.Where(c => c.ColumnName.StartsWith(table.ModelName)))
                {
                    if (table.AutobahnDomainId != refdom?.Id)
                    {
                        table.AutobahnDomainId = col.AutobahnDomainId;
                    }
                    else if (table.AutobahnDomainId != col.AutobahnDomainId)
                    {
                        table.AutobahnDomainId = comdom.Id;
                    }
                }
            }

            MauiModule.GenerateModule(autobahnDomains);

            csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", autobahnTables);
            //csv.WriteNDSElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\NDSElementsWithTechnicalName.csv", ndsElementsMetadata);

            // create a lookup table of models to properties
            //foreach (var model in types.GetTypes().ToList())
            //{
            //    var modelName = model.Name;
            //    List<string> propertiesToIgnore = new List<string>
            //    {
            //        "RecordStartDateTime",
            //        "RecordEndDateTime",
            //        "RecordStatusId",
            //        "Description",
            //        "Code",
            //        "Definition",
            //        "RefJurisdictionId",
            //        "SortOrder",
            //        "DataCollectionId",
            //        $"{modelName}Id"
            //    };
            //    //foreach (var prop in model.GetProperties())
            //    //{
            //    //    // no virtual properties.  We will handle those later as service calls
            //    //    if (prop.GetAccessors()[0].IsVirtual || propertiesToIgnore.Contains(prop.Name))
            //    //    {
            //    //        continue;
            //    //    }

            //    //    if (model.Name.EndsWith("Statu"))
            //    //    {
            //    //        modelName = modelName.Replace("Statu", "Status");
            //    //    }
            //    //    var propName = prop.Name;
            //    //    if (prop.Name.EndsWith("Statu"))
            //    //    {
            //    //        propName = propName.Replace("Statu", "Status");
            //    //    }
            //    //    var tableMeta = tablesMetadata.FirstOrDefault(t => t.TableName == model.Name
            //    //                                                       && t.ColumnName == prop.Name);
            //    //    if (model.Name.EndsWith("Statu") || tableMeta == null)
            //    //    {
            //    //        modelName = propName.Replace("Statu", "Status");
            //    //        tableMeta = tablesMetadata.FirstOrDefault(t => t.TableName == modelName
            //    //                                                       && t.ColumnName == propName);
            //    //    }
            //    //    if (prop.Name.EndsWith("Statu") || tableMeta == null)
            //    //    {
            //    //        propName = propName.Replace("Statu", "Status");
            //    //        tableMeta = tablesMetadata.FirstOrDefault(t => t.TableName == model.Name
            //    //                                                           && t.ColumnName == propName);
            //    //    }

            //    //    var tableMetaOnly = false;
            //    //    if (tableMeta == null)
            //    //    {
            //    //        if (prop.Name.EndsWith("Id"))
            //    //        {
            //    //            var id = "Id";
            //    //            tableMeta = tablesMetadata.FirstOrDefault(t => t.TableName == prop.Name.Replace(id, string.Empty)
            //    //                                                           && t.ColumnName == null);
            //    //            if (tableMeta == null)
            //    //            {
            //    //                Console.WriteLine($"retry table {model.Name} with column name {prop.Name} as {prop.Name.Replace(id, string.Empty)}");
            //    //            }
            //    //            else
            //    //            {
            //    //                tableMetaOnly = true;
            //    //            }
            //    //        }
            //    //    }
            //    //    if (tableMeta == null)
            //    //    {
            //    //        tableMeta = tablesMetadata.FirstOrDefault(t => t.TableName == model.Name
            //    //                                                       && t.ColumnName == null);
            //    //        if (tableMeta != null)
            //    //        {
            //    //            tableMetaOnly = true;
            //    //        }
            //    //    }
            //    //    CEDSElement element = null;
            //    //    if (tableMeta?.GlobalID != null)
            //    //    {
            //    //        element = cedsElementsMetadata.FirstOrDefault(c => c.GlobalID == tableMeta.GlobalID);
            //    //    }

            //    //    var modelProperty = new ModelProperty
            //    //    {
            //    //        Domain = tableMeta?.Domain ?? "Reference",
            //    //        Element = element,
            //    //        GlobalId = tableMeta?.GlobalID,
            //    //        ModelName = modelName,
            //    //        ModelType = model,
            //    //        PropertyInfo = prop,
            //    //        PropertyName = propName
            //    //    };
            //    //    if (tableMetaOnly)
            //    //    {
            //    //        modelProperty.PropertyInfo = null;
            //    //        modelProperty.PropertyName = modelName;
            //    //    }

            //    //    if (ModelProperties.Keys.Contains(modelProperty.PropertyName))
            //    //    {
            //    //        var hasprop = ModelProperties[modelProperty.PropertyName]
            //    //            .FirstOrDefault(p => p.ModelName == modelProperty.ModelName 
            //    //                                 && p.PropertyName == modelProperty.PropertyName);
            //    //        if (hasprop == null)
            //    //        {
            //    //            ModelProperties[propName].Add(modelProperty);
            //    //        }
            //    //    }
            //    //    else
            //    //    {
            //    //        ModelProperties.Add(propName, new List<ModelProperty> { modelProperty });
            //    //    }
            //    //}
            //}
        }
    }
}
