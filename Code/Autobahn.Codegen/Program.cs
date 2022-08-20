using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Security.Principal;
using Autobahn.Codegen.Models;
using Autobahn.Entities;
using Autobahn.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Autobahn.Codegen
{
    internal class Program
    {
        /// <summary>
        /// Set the domain of the table based on it name
        /// </summary>
        /// <param name="autobahnDomains"></param>
        /// <param name="table"></param>
        static void SetTableDomain(List<AutobahnDomain> autobahnDomains,  ref AutobahnTable table)
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

            if (table.TableName.StartsWith("Ae")
                || table.TableName.EndsWith("AE")
                || table.TableName.StartsWith("RefAE")
                || table.TableName.StartsWith("RefAe"))
            {
                table.ModuleName = aedom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("EL")
                || table.TableName.StartsWith("EarlyChildhood")
                || table.TableName.EndsWith("EL")
                || table.TableName.StartsWith("RefEL")
                || table.TableName.StartsWith("RefEarlyChildhood"))
            {
                table.ModuleName = eldom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Assessment")
                || table.TableName.StartsWith("Rubric")
                || table.TableName.StartsWith("Goal")
                || table.TableName.StartsWith("Learner")
                || table.TableName.StartsWith("RefAssessment")
                || table.TableName.StartsWith("RefRubric")
                || table.TableName.StartsWith("RefGoal")
                || table.TableName.StartsWith("RefLearner"))
            {
                table.ModuleName = assesdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Learning")
                || table.TableName.StartsWith("Peer")
                || table.TableName.StartsWith("RefLearning")
                || table.TableName.StartsWith("RefPeer"))
            {
                table.ModuleName = lrdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("K12")
                || table.TableName.StartsWith("RefK12"))
            {
                table.ModuleName = k12dom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Build")
                || table.TableName.StartsWith("Facility")
                || table.TableName.StartsWith("RefBuild")
                || table.TableName.StartsWith("RefFacility"))
            {
                table.ModuleName = facdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Ps")
                || table.TableName.StartsWith("PS")
                || table.TableName.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1
                || table.TableName.StartsWith("RefPs") 
                || table.TableName.StartsWith("RefPS"))
            {
                table.ModuleName = psdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Competency")
                || table.TableName.StartsWith("RefCompet"))
            {
                table.ModuleName = compdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Credential")
                || table.TableName.StartsWith("RefCred"))
            {
                table.ModuleName = creddom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Cte")
                || table.TableName.EndsWith("Cte")
                || table.TableName.StartsWith("RefCte"))
            {
                table.ModuleName = ctedom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Organization")
                || table.TableName.StartsWith("Person")
                || table.TableName.StartsWith("Staff")
                || table.TableName.StartsWith("Teacher")
                || table.TableName.StartsWith("Role")
                || table.TableName.StartsWith("RefOrganization")
                || table.TableName.StartsWith("RefPerson")
                || table.TableName.StartsWith("RefStaff")
                || table.TableName.StartsWith("RefTeacher")
                || table.TableName.StartsWith("RefRole"))
            {
                table.ModuleName = comdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("App")
                || table.TableName.StartsWith("Auth")
                || table.TableName.StartsWith("RefApp")
                || table.TableName.StartsWith("RefAuth"))
            {
                table.ModuleName = authdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            if (table.TableName.StartsWith("Workforce")
                || table.TableName.StartsWith("RefWorkforce"))
            {
                table.ModuleName = wfdom?.Module;
                table.Id ??= Guid.NewGuid();
            }
            table.ModuleName ??= invaliddom?.Module;
            table.Id ??= Guid.NewGuid();
        }

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
            var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv", false, "|");
            var comdom = autobahnDomains.First(d => d.Module == "Common");

            // Add any missing tables and set the domain for each table
            foreach (var type in types.GetTypes())
            {
                if (!type.IsClass)
                {
                    continue;
                }
                var table = autobahnTables.FirstOrDefault(t => t.TableName == type.Name
                                                && string.IsNullOrEmpty(t.ColumnName));
                if (table == null)
                {
                    table = new AutobahnTable
                    {
                        ModuleName = string.Empty,
                        TableName = type.Name,
                        ColumnName = string.Empty,
                        GlobalId = string.Empty,
                        Version = "--dbtable--"
                    };
                    autobahnTables.Add(table);
                }

                table.ColumnType = string.Empty;
                SetTableDomain(autobahnDomains, ref table);
            }

            //Add any missing classes and columns from the entities
            foreach (var type in types.GetTypes())
            {
                if (!type.IsClass)
                {
                    continue;
                }

                var tableName = type.GetCustomAttributes<TableAttribute>().First();
                AutobahnTable? table = autobahnTables.FirstOrDefault(t => t.TableName == tableName?.Name
                                                                          && string.IsNullOrEmpty(t.ColumnName));
                if (table == null)
                {
                    continue;
                }
                foreach (var prop in type.GetProperties())
                {
                    if (prop.GetAccessors()[0].IsVirtual)
                    {
                        continue;
                    }

                    var col = autobahnTables.FirstOrDefault(t => t.TableName == type.Name
                                                                 && t.ColumnName == prop.Name);
                    if (col == null)
                    {
                        col = new AutobahnTable
                        {
                            ColumnName = prop.Name,
                            ModuleName = table?.ModuleName,
                            TableName = table?.TableName,
                            GlobalId = string.Empty,
                            ColumnType = string.Empty,
                            Version = "--dbtable--"
                        };
                        autobahnTables.Add(col);
                        SetTableDomain(autobahnDomains, ref col);
                    }

                    col.Id ??= Guid.NewGuid();
                    if (prop.Name.EndsWith("Id"))
                    {
                        col.ColumnType = Nullable.GetUnderlyingType(prop.PropertyType) != null ? "Guid?" : "Guid";

                        // fkref so set the domain of the referenced table to this domain or
                        // common if it was in another domain
                        var fkref = autobahnTables.FirstOrDefault(t => t.TableName == col.ColumnName.Replace("Id", string.Empty)
                                    && string.IsNullOrEmpty(t.ColumnName));
                        if (fkref == null)
                        {
                            fkref = new AutobahnTable
                            {
                                ColumnName = string.Empty,
                                ModuleName = table?.ModuleName,
                                TableName = col.ColumnName.Replace("Id", string.Empty),
                                GlobalId = string.Empty,
                                ColumnType = string.Empty,
                                Version = "--dbtable--"
                            };
                            autobahnTables.Add(fkref);
                            SetTableDomain(autobahnDomains, ref fkref);
                        }
                        if (fkref.ModuleName == string.Empty)
                        {
                            foreach (var item in autobahnTables.Where(t => t.TableName == fkref.TableName))
                            {
                                item.ModuleName = col.ModuleName;
                            }
                        }
                        if (fkref.ModuleName != "Invalid" && fkref.ModuleName != col.ModuleName)
                        {
                            foreach (var item in autobahnTables.Where(t => t.TableName == fkref.TableName))
                            {
                                item.ModuleName = comdom?.Module;
                            }
                        }
                    }
                    else
                    {
                        col.ColumnType = Nullable.GetUnderlyingType(prop.PropertyType) != null
                            ? $"{Nullable.GetUnderlyingType(prop.PropertyType)}?"
                            : $"{prop.PropertyType}";
                    }
                }
            }

            // Write the updated table file
            csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", autobahnTables, true, ",");

            return autobahnTables;
        }

        private static List<AutobahnElement> GetAutobahnElements()
        {
            var csv = new CSVServices();
            var CEDSElements = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv", "|");

            // Cleanup the Global Id
            int output;
            foreach (var element in CEDSElements.Where(element => !Int32.TryParse(element.GlobalID, out output)))
            {
                element.GlobalID = string.Empty;
            }

            // save off the updated elements
            csv.WriteCEDSlementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv", CEDSElements, "|");

            // return the new list
            return csv.ReadAutobahnElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnElements.csv", "|"); ;
        }

        static void Main(string[] args)
        {
            var csv = new CSVServices();
            var types = Assembly.Load(typeof(Activity).Assembly.FullName);
            var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
            var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnTables.csv", true, ",");
            var autobahnElements = GetAutobahnElements();

            //SeedOrganization();
            //SeedRefRecordStatusType();
            //SeedRefRecordStatusCreatorEntity();

            var autobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\MarcRelator.csv");
//            csv.WriteReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv", autobahnMarc, false, "|");
            var marc = autobahnTables.Where(t => t.TableName == "RefMarcRelator");
            var RefAutobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv").ToList();
            var domainReferenceList = BuildTableListByProperty(autobahnTables);

            var one = domainReferenceList.Where(t => t.Value.Count == 1).ToList();
            var two = domainReferenceList.Where(t => t.Value.Count == 2).ToList();
            var many = domainReferenceList.Where(t => t.Value.Count > 2).ToList();
            var manymore = domainReferenceList.Where(t => t.Key.StartsWith("RefM")).ToList();

            MauiModule.GenerateModule(autobahnDomains, autobahnTables, autobahnElements, types.GetTypes().ToList(), domainReferenceList);
        }

        private static void SeedRefRecordStatusType()
        {
            var csv = new CSVServices();
            using (var ctx = new AutobahnCommonContext())
            {
                var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusType.csv");
                foreach (var item in reftype)
                {
                    ctx.RefRecordStatusType.Add(new RefRecordStatusType
                    {
                        Id = item.Id, // ?? Guid.NewGuid(),
                        Code = item.Code,
                        Description = item.Description,
                        Definition = item.Definition,
                        SortOrder = item.SortOrder
                    });
                }

                ctx.SaveChanges();
            }
        }

        private static void SeedRefRecordStatusCreatorEntity()
        {
            var csv = new CSVServices();
            using (var ctx = new AutobahnCommonContext())
            {
                var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusCreatorEntity.csv");
                foreach (var item in reftype)
                {
                    ctx.RefRecordStatusCreatorEntity.Add(new RefRecordStatusCreatorEntity
                    {
                        Id = item.Id, // ?? Guid.NewGuid(),
                        Code = item.Code,
                        Description = item.Description,
                        Definition = item.Definition,
                        SortOrder = item.SortOrder
                    });
                }

                ctx.SaveChanges();
            }
        }

        private static void SeedOrganization()
        {
            using (var ctx = new AutobahnCommonContext())
            {
                // Autobahn
                var Organization = new Organization { Id = Guid.Parse("22B1FD25-AE5C-4B03-B463-284D0C1B49F5") };
                ctx.Organization.Add(Organization);

                // Project GutenBurg
                Organization = new Organization { Id = Guid.Parse("BC734F30-EADD-4456-9B34-8583ABC17CD0") };
                ctx.Organization.Add(Organization);

                ctx.SaveChanges();
            }
        }

        private static Dictionary<string, List<AutobahnTable>> BuildTableListByProperty(List<AutobahnTable> tables)
        {
            var domainFiles = new Dictionary<string, List<AutobahnTable>>();
            foreach (var table in tables.Where(t => t.ColumnName.StartsWith("Ref") && t.ColumnName.EndsWith("Id")))
            {
                var columnKey = table.ColumnName.Replace("Id", string.Empty);
                if (columnKey.StartsWith("RefMarc"))
                {

                }
                if (domainFiles.ContainsKey(columnKey))
                {
                    var exists = domainFiles.Values.Any(v => v.Any(t => t.TableName == table.TableName));
                    if (!exists)
                    {
                        domainFiles[columnKey].Add(table);
                    }
                }
                else
                {
                    domainFiles.Add(columnKey, new List<AutobahnTable>());
                    domainFiles[columnKey].Add(table);
                }
            }

            return  domainFiles;
        }
    }
}
