//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFamilyIncomeSourceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFamilyIncomeSource Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFamilyIncomeSource"> List
         /// </summary>
        public static List<RefFamilyIncomeSource> RefFamilyIncomeSourceList = new List<RefFamilyIncomeSource> =
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("9fcdb919-2980-4c18-acf7-a984482e3fe9"), Code="Wages is a source of total family income.", Description="Wages", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("1365eceb-55f4-4162-b8d5-c2e2b8e59da3"), Code="Alimony is a source of total family income.", Description="Alimony", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("ab586a06-7a54-4bb7-b86c-0366645eb100"), Code="Child support is a source of total family income.", Description="ChildSupport", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("7311cda3-36ec-47a4-9b8a-848ed4d3e56c"), Code="Worker's compensation is a source of total family income.", Description="WorkersComp", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("f2d18618-7dbb-4780-a1ad-1b7163876fac"), Code="Unemployment is a source of total family income.", Description="Unemployment", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("af2a3a2f-90e4-4745-8bc0-265a130111db"), Code="Supplemental security income is a source of total family income.", Description="SSI", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("b6c71000-d4ea-4044-a6e8-4d082961665b"), Code="Temporary assistance for needy families is a source of total family income.", Description="TANF", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("38baedd6-aaa0-4ef1-8000-a42b332bbca9"), Code="Agricultural is a source of total family income.", Description="Agricultural", Definition="", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("eeee7fd8-e71c-4c23-bdb4-bd8d1affa6b7"), Code="A source of total family income in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFamilyIncomeSource Pick List
         /// </summary>
        public static List<RefFamilyIncomeSource> RefFamilyIncomeSourcePickList = new List<RefFamilyIncomeSource> =
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("9fcdb919-2980-4c18-acf7-a984482e3fe9"), Code="Wages is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("1365eceb-55f4-4162-b8d5-c2e2b8e59da3"), Code="Alimony is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("ab586a06-7a54-4bb7-b86c-0366645eb100"), Code="Child support is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("7311cda3-36ec-47a4-9b8a-848ed4d3e56c"), Code="Worker's compensation is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("f2d18618-7dbb-4780-a1ad-1b7163876fac"), Code="Unemployment is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("af2a3a2f-90e4-4745-8bc0-265a130111db"), Code="Supplemental security income is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("b6c71000-d4ea-4044-a6e8-4d082961665b"), Code="Temporary assistance for needy families is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("38baedd6-aaa0-4ef1-8000-a42b332bbca9"), Code="Agricultural is a source of total family income.", SortOrder=0 },
            new RefFamilyIncomeSource { Id=Guid.Parse("eeee7fd8-e71c-4c23-bdb4-bd8d1affa6b7"), Code="A source of total family income in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
