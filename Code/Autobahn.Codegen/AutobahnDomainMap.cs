// *******************************************************************************************************
//   File:      AutobahnDomainMap.cs
//   CreatedAt: 07/31/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************
using Autobahn.Entities;
using CsvHelper.Configuration;

namespace AutobahnCodeGen
{
    public sealed class AutobahnDomainMap : ClassMap<AutobahnDomain>
    {
        public AutobahnDomainMap()
        {
            Map(x => x.Module).Index(0);
            Map(x => x.Name).Index(1);
            Map(x => x.Description).Index(2);
            Map(x => x.Id).Index(3);
        }
    }
}