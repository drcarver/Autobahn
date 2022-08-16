// *******************************************************************************************************
//   File:      AutobahnDomainMap.cs
//   CreatedAt: 07/31/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************
using Autobahn.Entities;
using CsvHelper.Configuration;

namespace Autobahn.Codegen.Maps
{
    public sealed class AutobahnTableMap : ClassMap<AutobahnTable>
    {
        public AutobahnTableMap()
        {
            Map(x => x.GlobalId).Index(0);
            Map(x => x.TableName).Index(1);
            Map(x => x.ColumnName).Index(2);
            Map(x => x.Version).Index(3);
            Map(x => x.ColumnType).Index(4);
            Map(x => x.AutobahnDomainId).Index(5);
            Map(x => x.Id).Index(5);
            Map(x => x.ModuleName).Index(6);
    }
    }
}
