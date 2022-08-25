using Autobahn.Codegen.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SchemaOrg;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Autobahn.Codegen;

internal class Program
{
    /// <summary>
    /// Set the domain of the table based on it name
    /// </summary>
    /// <param name="autobahnDomains"></param>
    /// <param name="table"></param>
    static void SetTableDomain(List<AutobahnDomain> autobahnDomains, ref AutobahnEntity table)
    {
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

        if (table.Name.StartsWith("Ae")
            || table.Name.EndsWith("AE")
            || table.Name.StartsWith("RefAE")
            || table.Name.StartsWith("RefAe"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = aedom.Module;
        }
        if (table.Name.StartsWith("EL")
            || table.Name.StartsWith("EarlyChildhood")
            || table.Name.EndsWith("EL")
            || table.Name.StartsWith("RefEL")
            || table.Name.StartsWith("RefEarlyChildhood"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = eldom.Module;
        }
        if (table.Name.StartsWith("Assessment")
            || table.Name.StartsWith("Rubric")
            || table.Name.StartsWith("Goal")
            || table.Name.StartsWith("Learner")
            || table.Name.StartsWith("RefAssessment")
            || table.Name.StartsWith("RefRubric")
            || table.Name.StartsWith("RefGoal")
            || table.Name.StartsWith("RefLearner"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
        }
        if (table.Name.StartsWith("Learning")
            || table.Name.StartsWith("Peer")
            || table.Name.StartsWith("RefLearning")
            || table.Name.StartsWith("RefPeer"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = lrdom.Module;
        }
        if (table.Name.StartsWith("K12")
            || table.Name.StartsWith("RefK12"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = k12dom.Module;
        }
        if (table.Name.StartsWith("Build")
            || table.Name.StartsWith("Facility")
            || table.Name.StartsWith("RefBuild")
            || table.Name.StartsWith("RefFacility"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = facdom.Module;
        }
        if (table.Name.StartsWith("Ps")
            || table.Name.StartsWith("PS")
            || table.Name.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1
            || table.Name.StartsWith("RefPs")
            || table.Name.StartsWith("RefPS"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = psdom.Module;
        }
        if (table.Name.StartsWith("Competency")
            || table.Name.StartsWith("RefCompet"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = compdom.Module;
        }
        if (table.Name.StartsWith("Credential")
            || table.Name.StartsWith("RefCred"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = creddom.Module;
        }
        if (table.Name.StartsWith("Cte")
            || table.Name.EndsWith("Cte")
            || table.Name.StartsWith("RefCte"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = ctedom.Module;
        }
        if (table.Name.StartsWith("Organization")
            || table.Name.StartsWith("Person")
            || table.Name.StartsWith("Staff")
            || table.Name.StartsWith("Teacher")
            || table.Name.StartsWith("Role")
            || table.Name.StartsWith("RefOrganization")
            || table.Name.StartsWith("RefPerson")
            || table.Name.StartsWith("RefStaff")
            || table.Name.StartsWith("RefTeacher")
            || table.Name.StartsWith("RefRole"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = comdom.Module;
        }
        if (table.Name.StartsWith("App")
            || table.Name.StartsWith("Auth")
            || table.Name.StartsWith("RefApp")
            || table.Name.StartsWith("RefAuth"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = authdom.Module;
        }
        if (table.Name.StartsWith("Workforce")
            || table.Name.StartsWith("RefWorkforce"))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = wfdom.Module;
        }
    }

    ///// <summary>
    ///// Return the list of autobahn domains
    ///// </summary>
    ///// <returns>Return the list of Autobahn domains</returns>
    //private static List<AutobahnDomain> GetAutobahnDomains()
    //{
    //    var csv = new CSVServices();
    //    return csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
    //}

    /// <summary>
    /// Return the list of autobahn entities from a list of types
    /// </summary>
    /// <returns>Return the list of Autobahn Entities</returns>
    private static List<AutobahnEntity> GetAutobahnEntities(List<Type> types, List<AutobahnDomain> autobahnDomains)
    {
        // iterate the known types and create a list of
        // autobahn types
        List<AutobahnEntity> autobahnEntities = new();
        foreach (var type in types)
        {
            if (!type.IsClass)
            {
                continue;
            }

            var entity = new AutobahnEntity(type);
            if (entity.Attributes.CommentAttribute == null)
            {
                entity.Attributes.CommentAttribute = new($"The {entity.Name} Entity");
            }
            SetTableDomain(autobahnDomains, ref entity);
            autobahnEntities.Add(entity);
        }

        return autobahnEntities;
    }

    //private static List<AutobahnElement> GetAutobahnElements()
    //{
    //    var csv = new CSVServices();
    //    var CEDSElements = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv", "|");

    //    // Cleanup the Global Id
    //    int output;
    //    foreach (var element in CEDSElements.Where(element => !Int32.TryParse(element.GlobalID, out output)))
    //    {
    //        element.GlobalID = string.Empty;
    //    }

    //    // save off the updated elements
    //    csv.WriteCEDSlementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv", CEDSElements, "|");

    //    // return the new list
    //    return csv.ReadAutobahnElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv", "|"); ;

    static void Main(string[] args)
    {
        var csv = new CSVServices();
        var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
        var autobahnElements = csv.ReadAutobahnElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv");
        var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv", false);

        // Autobahn Domains
        var autobahnEntites = GetAutobahnEntities(Assembly.GetExecutingAssembly().GetExportedTypes().OrderBy(o => o.Name).ToList(), autobahnDomains);

        var schemaEntites = GetSchemaEntities(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\schemaorg-all-http.jsonld");

        //SeedOrganization();
        //SeedRefRecordStatusType();
        //SeedRefRecordStatusCreatorEntity();

        //var autobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\MarcRelator.csv");
        //            csv.WriteReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv", autobahnMarc, false, "|");
        //var marc = autobahnTables.Where(t => t.TableName == "RefMarcRelator");
        //var RefAutobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv").ToList();
        //var domainReferenceList = BuildTableListByProperty(autobahnTables);

        var location = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Autobahn\Generated\";
        MauiModule.GenerateModule(location, autobahnEntites, autobahnDomains); //autobahnDomains, autobahnTables, autobahnElements, types.GetTypes().ToList(), domainReferenceList);
    }

    private static List<AutobahnEntity> GetSchemaEntities(string location)
    {
        var domains = new Dictionary<string, List<string>>();
        Root SchemaOrg = JsonConvert.DeserializeObject<Root>(File.ReadAllText(location));

        // First build the list of entites and the domain
        // list that goes with them
        var graphlist = new List<AutobahnEntity>();
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdfs:Class") && !schema.SchemaType.Contains("schema:DataType"))
            {
                var entityName = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                var entity = graphlist.FirstOrDefault(e => e.Name == entityName);
                if (entity == null)
                {
                    entity = new AutobahnEntity
                    {
                        Name = entityName,
                    };
                    if (!string.IsNullOrEmpty(schema.RdfsComment))
                    {
                        entity.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                    }
                    if (schema.RdfsSubClassOf != null)
                    {
                        foreach (var subclass in schema.RdfsSubClassOf)
                        {
                            var subClassName = FirstCharToUpper(subclass.Id.Replace("schema:", string.Empty));
                            if (!entity.SubClass.Contains(subClassName) && subClassName != entityName)
                            {
                                entity.SubClass.Add(subClassName);
                            }

                            // Update the domain map (entities that inherit from many others)
                            if (domains.ContainsKey(subClassName))
                            {
                                if (!domains[subClassName].Contains(entityName))
                                {
                                    domains[subClassName].Add(entityName);
                                }
                            }
                            else
                            {
                                domains.Add(subClassName, new List<string> { entityName });
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(schema.RdfsLabel))
                    {
                        entity.Label = FirstCharToUpper(schema.RdfsLabel);
                    }
                    if (!entity.SubClass.Any())
                    {
                        entity.SubClass.Add("EntityBase");
                    }
                    entity.Attributes.TableAttribute = new TableAttribute(entity.Name);
                    entity.SubClass.Add($"I{entity.Name}");
                    graphlist.Add(entity);
                }
            }
        }

        // Add the properties to the entity
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdf:Property"))
            {
                if (schema.SchemaDomainIncludes != null)
                {
                    foreach (var schemaName in schema.SchemaDomainIncludes)
                    {
                        var entityName = FirstCharToUpper(schemaName.Id.Replace("schema:", string.Empty));
                        var entity = graphlist.FirstOrDefault(e => e.Name == entityName);
                        if (entity != null)
                        {
                            var propName = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                            var prop = entity.AutobahnProperties.FirstOrDefault(p => p.Name == propName);
                            if (prop == null)
                            {
                                prop = new AutobahnProperty
                                {
                                    Name = propName,
                                    PropertyType = SchemaPropertyType(schema.SchemaRangeIncludes)

                                };
                                if (!string.IsNullOrEmpty(schema.RdfsComment))
                                {
                                    prop.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                                }
                                if (!string.IsNullOrEmpty(schema.RdfsLabel))
                                {
                                    entity.Label = FirstCharToUpper(schema.RdfsLabel);
                                }
                                var fkEntity = graphlist.FirstOrDefault(e => e.Name == prop.PropertyType);
                                if (fkEntity != null)
                                {
                                    var virtualProperty = new AutobahnProperty
                                    {
                                        Name = propName,
                                        PropertyType = propName,
                                        IsVirtual = true,
                                    };
                                    virtualProperty.Attributes.CommentAttribute = prop.Attributes.CommentAttribute;
                                    entity.AutobahnProperties.Add(virtualProperty);
                                    prop.Attributes.ForeignKeyAttribute = new ForeignKeyAttribute(prop.PropertyType);
                                    prop.Name = $"{prop.Name}Id";
                                    prop.PropertyType = "Guid";
                                }
                                entity.AutobahnProperties.Add(prop);
                            }
                        }
                    }
                }
            }
        }

        return graphlist;
    }

    private static AutobahnElement? GetEntityMeta(string entityName, 
        string propertyName, List<AutobahnTable> tables,
        List<AutobahnElement> elements)
    {
        AutobahnTable? tableMeta;
        if (string.IsNullOrEmpty(propertyName))
        {
            tableMeta = tables.FirstOrDefault(t => t.TableName == entityName);
        }
        else
        {
            tableMeta = tables.FirstOrDefault(e => e.TableName == entityName && e.ColumnName == propertyName);
        }
        AutobahnElement? element = null;
        if (!string.IsNullOrEmpty(tableMeta?.GlobalId))
        {
            foreach (var item in elements)
            {
                int intOut;
                Int32.TryParse(item.GlobalID, out intOut);
                if (intOut.ToString() == tableMeta?.GlobalId)
                {
                    return item;
                }
            }
        }
        return element;
    }

    private static string SchemaPropertyType(List<SchemaRangeIncludes> schemaRangeIncludes)
    {
        var nettype = string.Empty;
        foreach (var propType in schemaRangeIncludes)
        {
            switch (propType.Id)
            {
                case "schema:Text":
                    nettype = "string";
                    break;
                case "schema:Boolean":
                    nettype = "bool";
                    break;
                case "schema:Date":
                    nettype = "Date";
                    break;
                case "schema:DateTime":
                    nettype = "DateTime";
                    break;
                case "schema:Number":
                    nettype = "int";
                    break;
                case "schema:Time":
                    nettype = "Time";
                    break;
                default:
                    nettype = FirstCharToUpper(propType.Id.Replace("schema:", string.Empty));
                    break;
            }
        }
        return nettype;
    }

    //private static void SeedRefRecordStatusType()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusType.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusType.Add(new RefRecordStatusType
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedRefRecordStatusCreatorEntity()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusCreatorEntity.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusCreatorEntity.Add(new RefRecordStatusCreatorEntity
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedOrganization()
    //{
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        // Autobahn
    //        var Organization = new Organization { Id = Guid.Parse("22B1FD25-AE5C-4B03-B463-284D0C1B49F5") };
    //        ctx.Organization.Add(Organization);

    //        // Project GutenBurg
    //        Organization = new Organization { Id = Guid.Parse("BC734F30-EADD-4456-9B34-8583ABC17CD0") };
    //        ctx.Organization.Add(Organization);

    //        ctx.SaveChanges();
    //    }
    //}

    //private static Dictionary<string, List<AutobahnTable>> BuildTableListByProperty(List<AutobahnTable> tables)
    //{
    //    var domainFiles = new Dictionary<string, List<AutobahnTable>>();
    //    foreach (var table in tables.Where(t => t.ColumnName.StartsWith("Ref") && t.ColumnName.EndsWith("Id")))
    //    {
    //        var columnKey = table.ColumnName.Replace("Id", string.Empty);
    //        if (columnKey.StartsWith("RefMarc"))
    //        {

    //        }
    //        if (domainFiles.ContainsKey(columnKey))
    //        {
    //            var exists = domainFiles.Values.Any(v => v.Any(t => t.TableName == table.TableName));
    //            if (!exists)
    //            {
    //                domainFiles[columnKey].Add(table);
    //            }
    //        }
    //        else
    //        {
    //            domainFiles.Add(columnKey, new List<AutobahnTable>());
    //            domainFiles[columnKey].Add(table);
    //        }
    //    }

    //    return  domainFiles;
    //}

    /// <summary>
    /// Convert a string to start with a upper case character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to upper case</returns>
    public static string FirstCharToUpper(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        return new string(array);
    }

    /// <summary>
    /// Convert a string to start with a upper lower character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to lower case</returns>
    public static string FirstCharToLower(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsUpper(array[0]))
            {
                array[0] = char.ToLower(array[0]);
            }
        }
        return new string(array);
    }
}
