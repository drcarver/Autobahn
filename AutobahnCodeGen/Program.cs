using System;
using System.Collections.Generic;

namespace AutobahnCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<CEDSElement>> CEDDomains = new Dictionary<string, List<CEDSElement>>();
            var csv = new CEDSService();
            var records = csv.ReadCSVFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\AutobahnCodeGen\CEDS-V10.csv");

            foreach (var record in records)
            {
                var domains = record.DomainEntityCategory.Replace(Environment.NewLine, "|").Replace("||", "|").Split('|');
                foreach (var domain in domains)
                {
                    var domainName = domain.Replace("->", "|").Split('|');
                    if (CEDDomains.ContainsKey(domainName[0]))
                    {
                        CEDDomains[domainName[0]].Add(record);
                    }
                    else
                    {
                        CEDDomains.Add(domainName[0], new List<CEDSElement>());
                        CEDDomains[domainName[0]].Add(record);
                    }
                }
            }


            foreach (var dir in CEDDomains.Keys)
            {
                var fname = dir.Replace(" ", string.Empty);
                var filedir = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
                MauiModule.GenerateModule(filedir, $"Autobahn.{fname}", CEDDomains[dir]);
            }
        }
    }

}
