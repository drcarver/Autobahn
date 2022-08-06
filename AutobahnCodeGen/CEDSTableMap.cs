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
                Map(x => x.GlobalID).Index(0);
                Map(x => x.TableName).Index(1);
                Map(x => x.ColumnName).Index(2);
                Map(x => x.Version).Index(3);
            }
        }
    }

}