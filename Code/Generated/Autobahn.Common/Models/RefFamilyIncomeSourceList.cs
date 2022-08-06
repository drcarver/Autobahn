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
        public static List<RefFamilyIncomeSource> RefFamilyIncomeSourceList = new List<RefFamilyIncomeSource>
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("1ee6849f-5fdb-48c5-ae45-c7b31837c2fc"), Code="Wages", Description="Wages", Definition="Wages is a source of total family income.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("23ec1b66-5a99-4a51-a0aa-359992f9ea99"), Code="Alimony", Description="Alimony", Definition="Alimony is a source of total family income.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("51229a02-72e5-4955-904a-da203e035020"), Code="ChildSupport", Description="Child support", Definition="Child support is a source of total family income.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("84d4dc02-a93c-4b47-8fb3-c16285fae125"), Code="WorkersComp", Description="Worker's compensation", Definition="Worker's compensation is a source of total family income.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("d7b7eece-78e9-4c79-9308-772e66ab9162"), Code="Unemployment", Description="Unemployment", Definition="Unemployment is a source of total family income.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("d18777e7-9148-4e6f-bea7-e79907ca23e8"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income is a source of total family income.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("64b3cb22-9df8-45a5-9517-0d08c0b7a920"), Code="TANF", Description="Temporary assistance for needy families", Definition="Temporary assistance for needy families is a source of total family income.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("3bbdcfae-fd78-4e76-9b18-3671e66fe87f"), Code="Agricultural", Description="Agricultural", Definition="Agricultural is a source of total family income.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("3d8b8d1f-d4cc-4425-a072-b25c1ebf6a8c"), Code="Other", Description="Other", Definition="A source of total family income in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefFamilyIncomeSource Pick List
         /// </summary>
        public static List<RefFamilyIncomeSource> RefFamilyIncomeSourcePickList = new List<RefFamilyIncomeSource>
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("1ee6849f-5fdb-48c5-ae45-c7b31837c2fc"), Code="Wages", Description="Wages", SortOrder=Convert.ToDecimal("1.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("23ec1b66-5a99-4a51-a0aa-359992f9ea99"), Code="Alimony", Description="Alimony", SortOrder=Convert.ToDecimal("2.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("51229a02-72e5-4955-904a-da203e035020"), Code="ChildSupport", Description="Child support", SortOrder=Convert.ToDecimal("3.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("84d4dc02-a93c-4b47-8fb3-c16285fae125"), Code="WorkersComp", Description="Worker's compensation", SortOrder=Convert.ToDecimal("4.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("d7b7eece-78e9-4c79-9308-772e66ab9162"), Code="Unemployment", Description="Unemployment", SortOrder=Convert.ToDecimal("5.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("d18777e7-9148-4e6f-bea7-e79907ca23e8"), Code="SSI", Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("64b3cb22-9df8-45a5-9517-0d08c0b7a920"), Code="TANF", Description="Temporary assistance for needy families", SortOrder=Convert.ToDecimal("7.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("3bbdcfae-fd78-4e76-9b18-3671e66fe87f"), Code="Agricultural", Description="Agricultural", SortOrder=Convert.ToDecimal("8.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("3d8b8d1f-d4cc-4425-a072-b25c1ebf6a8c"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
