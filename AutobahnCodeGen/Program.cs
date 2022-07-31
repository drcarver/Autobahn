using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;

namespace AutobahnCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<CEDSElement>> CEDDomains = new Dictionary<string, List<CEDSElement>>();
            List<CEDSElement> CEDElements = new List<CEDSElement>();
            var csv = new CEDSService();
            var records = csv.ReadCSVFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\AutobahnCodeGen\CEDS-V10.csv");
            var types = Assembly.Load(typeof(Autobahn.Entities.Activity).Assembly.FullName);

            foreach (var record in records)
            {
                var domains = record.DomainEntityCategory.Replace(Environment.NewLine, "|").Replace("||", "|")
                    .Split('|');
                foreach (var domain in domains)
                {
                    var domaintable = domain.Replace("->", "|").Split('|');
                    if (domaintable.Length >= 2)
                    {
                        var newrecord = record.Clone();
                        newrecord.DomainName = domaintable[0].Trim();
                        newrecord.TableName = domaintable[1].Replace(" ", string.Empty).Trim();
                        CEDElements.Add(newrecord);
                    }
                }
            }

            foreach (var element in CEDElements)
            {
                if (CEDDomains.Keys.Contains(element.DomainName.ToLower().Trim()))
                {
                    CEDDomains[element.DomainName.ToLower().Trim()].Add(element);
                }
                else
                {
                    CEDDomains.Add(element.DomainName.ToLower().Trim(), new List<CEDSElement>());
                    CEDDomains[element.DomainName.ToLower().Trim()].Add(element);
                }
            }

            foreach (var dir in CEDDomains.Keys)
            {
                var fname = CEDDomains[dir][0].DomainName.Replace(" ", string.Empty);
                var filedir = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
                MauiModule.GenerateModule(filedir, $"Autobahn.{fname}", CEDDomains[dir], types.GetTypes());
            }

            var skeys = MauiModule.RefModels.Values.Where(c => c.Count == 1)?.Count();
            var mkeys = MauiModule.RefModels.Values.Where(c => c.Count > 1)?.Count();
        }
    }

}
