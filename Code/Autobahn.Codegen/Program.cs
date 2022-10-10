using System.Reflection;

using Autobahn.Codegen.Models;

using SchemaOrg;

namespace Autobahn.Codegen;

internal class Program
{

    /// <summary>
    /// Return the list of autobahn entities from a list of types
    /// </summary>
    /// <returns>Return the list of Autobahn Entities</returns>
    private static List<AutobahnEntity> GetAutobahnEntities(
        List<Type> types, 
        List<AutobahnDomain> domains, 
        List<AutobahnTable> tables, 
        List<AutobahnElement> elements)
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

            var entity  = new AutobahnEntity(type);
            var globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && string.IsNullOrEmpty(t.ColumnName.Trim()))?.GlobalId;
            entity.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
            if (entity.Attributes.CommentAttribute == null)
            {
                if (!string.IsNullOrEmpty(entity.AutobahnElement?.Definition))
                {
                    entity.Attributes.CommentAttribute = new($"{entity.AutobahnElement?.Definition}");
                }
                else
                {
                    entity.Attributes.CommentAttribute = new($"The {entity.Name} ");
                }
            }
            foreach (var prop in entity.AutobahnProperties)
            {
                globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && t.ColumnName == prop.Name)?.GlobalId;
                prop.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
                if (!string.IsNullOrEmpty(prop.AutobahnElement?.Definition))
                {
                    prop.Attributes.CommentAttribute = new(prop.AutobahnElement.Definition);
                }
            }
            autobahnEntities.Add(entity);
        }

        foreach (var entity in autobahnEntities.Where(e => e.Attributes.TableAttribute?.Schema == null))
        {
            if (entity.Attributes.TableAttribute == null)
            {
                continue;
            }
            entity.Attributes.TableAttribute.Schema = "Invalid";
        }
        return autobahnEntities;
    }

    static async Task Main(string[] args)
    {
        var csv = new CSVServices();
        var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
        var autobahnElements = csv.ReadAutobahnElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
        var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv");

        // Autobahn Domains
        var autobahnEntites = GetAutobahnEntities(
            Assembly.GetExecutingAssembly().GetExportedTypes().OrderBy(o => o.Name).ToList(), 
            autobahnDomains, autobahnTables, autobahnElements);

        var schemaEntites = GetSchemaEntities(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\schemaorg-all-http.jsonld");

        var tickerlist = JsonConvert.DeserializeObject<List<Ticker>>(File.ReadAllText(@"C:\Users\drcarver\Desktop\codegen\FMP\Data\list.json"));
        int symbolLength = 0;
        int nameLength = 0;
        int exchangenameLength = 0;
        int exchangeshortnameLength = 0;
        List<string> tickertype = new();
        List<string> exchangeabbr = new();
        foreach (var ticker in tickerlist)
        {
            if (ticker.Symbol.Length > symbolLength) symbolLength = ticker.Symbol.Length;
            if (ticker.Name.Length > nameLength) nameLength = ticker.Name.Length;
            if (ticker.Exchange.Length > exchangenameLength) exchangenameLength = ticker.Exchange.Length;
            if (ticker.ExchangeShortName.Length > exchangeshortnameLength) exchangeshortnameLength = ticker.ExchangeShortName.Length;
            if (!tickertype.Contains(ticker.TickerType))
            {
                tickertype.Add(ticker.TickerType);
            }
            if (!exchangeabbr.Contains(ticker.Exchange))
            {
                exchangeabbr.Add(ticker.Exchange);
            }
        }

        Console.WriteLine($"TickerCount={tickerlist.Count()}");
        Console.WriteLine($"MaxSymbolLength={symbolLength}");
        Console.WriteLine($"MaxNameLength={nameLength}");
        Console.WriteLine($"MaxExchangeNameLength={exchangenameLength}");
        Console.WriteLine($"MaxExchangeShortNameLength={exchangeshortnameLength}");
        foreach (var item in tickertype)
        {
            Console.WriteLine($"{item}");
        }
        foreach (var item in exchangeabbr)
        {
            Console.WriteLine($"{item}");
        }

        //SeedOrganization();
        //SeedRefRecordStatusType();
        //SeedRefRecordStatusCreator();

        //var autobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\MarcRelator.csv");
        //            csv.WriteReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv", autobahnMarc, false, "|");
        //var marc = autobahnTables.Where(t => t.TableName == "RefMarcRelator");
        //var RefAutobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv").ToList();
        //var domainReferenceList = BuildTableListByProperty(autobahnTables);

        var location = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\src\";
        MauiModule.GenerateModule(location, autobahnEntites, autobahnDomains);
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
                var Name = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                var entity = graphlist.FirstOrDefault(e => e.Name == Name);
                if (entity == null)
                {
                    entity = new AutobahnEntity
                    {
                        Name = Name,
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
                            if (!entity.SubClass.Contains(subClassName) && subClassName != Name)
                            {
                                entity.SubClass.Add(subClassName);
                            }

                            // Update the domain map (entities that inherit from many others)
                            if (domains.ContainsKey(subClassName))
                            {
                                if (!domains[subClassName].Contains(Name))
                                {
                                    domains[subClassName].Add(Name);
                                }
                            }
                            else
                            {
                                domains.Add(subClassName, new List<string> { Name });
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(schema.RdfsLabel))
                    {
                        entity.Label = FirstCharToUpper(schema.RdfsLabel);
                    }
                    if (!entity.SubClass.Any())
                    {
                        entity.SubClass.Add("Base");
                    }
                    entity.Attributes.TableAttribute = new TableAttribute(entity.Name);
                    entity.SubClass.Add($"I{entity.Name}");
                    graphlist.Add(entity);
                }
            }
        }

        // Add the properties to the 
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdf:Property"))
            {
                if (schema.SchemaDomainIncludes != null)
                {
                    foreach (var schemaName in schema.SchemaDomainIncludes)
                    {
                        var Name = FirstCharToUpper(schemaName.Id.Replace("schema:", string.Empty));
                        var entity = graphlist.FirstOrDefault(e => e.Name == Name);
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
                                var fk = graphlist.FirstOrDefault(e => e.Name == prop.PropertyType);
                                if (fk != null)
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

    private static AutobahnElement? GetMeta(string Name, 
        string propertyName, List<AutobahnTable> tables,
        List<AutobahnElement> elements)
    {
        AutobahnTable? tableMeta;
        if (string.IsNullOrEmpty(propertyName))
        {
            tableMeta = tables.FirstOrDefault(t => t.TableName == Name);
        }
        else
        {
            tableMeta = tables.FirstOrDefault(e => e.TableName == Name && e.ColumnName == propertyName);
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

    //private static void SeedRefRecordStatusCreator()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusCreator.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusCreator.Add(new RefRecordStatusCreator
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
