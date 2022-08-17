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
            Map(x => x.GlobalId).Name("GlobalId");
            Map(x => x.TableName).Name("TableName");
            Map(x => x.ColumnName).Name("ColumnName");
            Map(x => x.Version).Name("Version");
            Map(x => x.ColumnType).Name("ColumnType");
            Map(x => x.Id).Name("Id");
            Map(x => x.ModuleName).Name("ModuleName");
    }
    }
}
