using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutobahnCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> CEDDomains = new Dictionary<string, List<string>>();
            List<CEDSElement> CEDElements = new List<CEDSElement>();
            var csv = new CEDSService();
            var cedsElementsMetadata = csv.ReadCEDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\CEDS-V10.csv");
            var ndsElementsMetadata = csv.ReadNDSElementsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\NDSElements.csv");
            var tablesMetadata = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\CEDSTables.csv");
            var types = Assembly.Load(typeof(Autobahn.Entities.Activity).Assembly.FullName);

            // Set the domains in the tablesMetadata
            foreach (var table in tablesMetadata)
            {
                if (table.TableName.StartsWith("Ae")
                    || table.TableName.EndsWith("AE"))
                {
                    table.Domain = "Adult Education";
                }
                if (table.TableName.StartsWith("EL") 
                    || table.TableName.StartsWith("EarlyChildhood"))
                {
                    table.Domain = "Early Learning";
                }
                if (table.TableName.StartsWith("Assessment")
                    || table.TableName.StartsWith("Rubric")
                    || table.TableName.StartsWith("Goal")
                    || table.TableName.StartsWith("Learner"))
                {
                    table.Domain = "Assessment";
                }
                if (table.TableName.StartsWith("Learning")
                    || table.TableName.StartsWith("Peer"))
                {
                    table.Domain = "Learning Resource";
                }
                if (table.TableName.StartsWith("K12"))
                {
                    table.Domain = "K12";
                }
                if (table.TableName.StartsWith("Build")
                    || table.TableName.StartsWith("Facility")
                   )
                {
                    table.Domain = "Facilities";
                }
                if (table.TableName.StartsWith("Ps")
                    || table.TableName.StartsWith("PS"))
                {
                    table.Domain = "Postsecondary";
                }
                if (table.TableName.StartsWith("Competency"))
                {
                    table.Domain = "Competencies";
                }
                if (table.TableName.StartsWith("Credential"))
                {
                    table.Domain = "Credentials";
                }
                if (table.TableName.StartsWith("Cte")
                    || table.TableName.EndsWith("Cte"))
                {
                    table.Domain = "Career and Technical";
                }
                if (table.TableName.StartsWith("Organization") 
                    || table.TableName.StartsWith("Person")
                    || table.TableName.StartsWith("Staff")
                    || table.TableName.StartsWith("Teacher")
                    || table.TableName.StartsWith("Role"))
                {
                    table.Domain = "Common";
                }
                if (table.TableName.StartsWith("App")
                    || table.TableName.StartsWith("Auth"))
                {
                    table.Domain = "Authentication and Authorization";
                }
                if (table.TableName.StartsWith("Ref"))
                {
                    table.Domain = "Reference";
                }
                if (table.TableName.StartsWith("Workforce"))
                {
                    table.Domain = "Workforce";
                }
                if (string.IsNullOrEmpty(table.Domain))
                {
                    table.Domain = "Common";
                }
            }

            // Set the reference to the correct domain
            foreach (var table in tablesMetadata.Where(t => t.TableName.StartsWith("Ref")))
            {
                foreach (var col in tablesMetadata.Where(c => c.ColumnName.StartsWith(table.TableName)))
                {
                    if (table.Domain == "Reference")
                    {
                        table.Domain = col.Domain;
                    }
                    else if (table.Domain != col.Domain)
                    {
                        table.Domain = "Common";
                    }
                }
            }

            // Set the technical name
            foreach (var col in ndsElementsMetadata)
            {
                var cedsElements = cedsElementsMetadata.Where(c => c.ElementName == col.ElementName);
                foreach (var element in cedsElements)
                {
                    col.TechnicalName = element.TechnicalName;
                }
            }

            // Create the Domains Dictionary
            foreach (var table in tablesMetadata)
            {
                if (CEDDomains.ContainsKey(table.Domain))
                {
                    if (!CEDDomains[table.Domain].Contains(table.TableName))
                    {
                        CEDDomains[table.Domain].Add(table.TableName);
                    }
                }
                else
                {
                    CEDDomains.Add(table.Domain, new List<string>());
                    CEDDomains[table.Domain].Add(table.TableName);
                }
            }

            MauiModule.GenerateModule(CEDDomains, tablesMetadata, types.GetTypes().ToList(), ndsElementsMetadata);

            //csv.WriteTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\CEDSTablesWithDomain.csv", tablesMetadata);
            //csv.WriteNDSElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\NDSElementsWithTechnicalName.csv", ndsElementsMetadata);

            //var skeys = MauiModule.RefModels.Values.Where(c => c.Count == 1)?.Count();
            //var mkeys = MauiModule.RefModels.Values.Where(c => c.Count > 1)?.Count();
        }
    }
}
