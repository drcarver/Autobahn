// *******************************************************************************************************
//   File:      AutobahnDomainMap.cs
//   CreatedAt: 07/31/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************
using Autobahn.Codegen.Models;
using CsvHelper.Configuration;
using System.Xml.Linq;

namespace Autobahn.Codegen.Maps
{
    internal sealed class AutobahnDomainMap : ClassMap<AutobahnDomain>
    {
        internal AutobahnDomainMap()
        {
            Map(x => x.Id).Index(4);
            Map(x => x.Module).Index(1);
            Map(x => x.Name).Index(2);
            Map(x => x.Description).Index(3);
            Map(x => x.SortOrder).Index(0);
        }
    }
}