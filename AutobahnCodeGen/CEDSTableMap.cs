// *******************************************************************************************************
//   File:      Class1.cs
//   CreatedAt: 07/31/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

namespace AutobahnCodeGen
{
    using CsvHelper.Configuration;

    namespace AutobahnCodeGen
    {
        public sealed class CEDSTableMap : ClassMap<CEDSTable>
        {
            public CEDSTableMap()
            {
                Map(x => x.GlobalID).Name("GlobalID");
                Map(x => x.TableName).Name("TableName");
                Map(x => x.ColumnName).Name("ColumnName");
                Map(x => x.Version).Name("Version");
            }
        }
    }

}