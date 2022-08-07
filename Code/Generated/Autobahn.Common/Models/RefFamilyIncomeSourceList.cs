//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFamilyIncomeSourceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFamilyIncomeSource Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFamilyIncomeSourceModel"> List
         /// </summary>
        public static List<RefFamilyIncomeSourceModel> RefFamilyIncomeSourceList = new List<RefFamilyIncomeSourceModel>
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("34c63970-0000-486f-8676-abc8efddad71"), Code="Wages", Description="Wages", Definition="Wages is a source of total family income.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("ea22610b-d2fc-4666-aca2-44b8ec461850"), Code="Alimony", Description="Alimony", Definition="Alimony is a source of total family income.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("f8d432b4-e713-4905-96e5-c8c997fdf7f2"), Code="ChildSupport", Description="Child support", Definition="Child support is a source of total family income.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("899288d8-08b6-403b-9b9c-a399dcec6a95"), Code="WorkersComp", Description="Worker's compensation", Definition="Worker's compensation is a source of total family income.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("cb28d589-e2b7-4d05-8ce6-12d3f1970388"), Code="Unemployment", Description="Unemployment", Definition="Unemployment is a source of total family income.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("5243b783-c099-4a5d-bc83-c1c32e363e47"), Code="SSI", Description="Supplemental security income", Definition="Supplemental security income is a source of total family income.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("612cef86-8981-4c37-b7fd-78fba68080dd"), Code="TANF", Description="Temporary assistance for needy families", Definition="Temporary assistance for needy families is a source of total family income.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("eb71a6e4-4d69-4453-af23-4a445e9285f7"), Code="Agricultural", Description="Agricultural", Definition="Agricultural is a source of total family income.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("53fff00f-4abe-4153-9616-35185068fe1a"), Code="Other", Description="Other", Definition="A source of total family income in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefFamilyIncomeSource Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFamilyIncomeSourceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFamilyIncomeSource { Id=Guid.Parse("34c63970-0000-486f-8676-abc8efddad71"), Description="Wages", SortOrder=Convert.ToDecimal("1.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("ea22610b-d2fc-4666-aca2-44b8ec461850"), Description="Alimony", SortOrder=Convert.ToDecimal("2.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("f8d432b4-e713-4905-96e5-c8c997fdf7f2"), Description="Child support", SortOrder=Convert.ToDecimal("3.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("899288d8-08b6-403b-9b9c-a399dcec6a95"), Description="Worker's compensation", SortOrder=Convert.ToDecimal("4.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("cb28d589-e2b7-4d05-8ce6-12d3f1970388"), Description="Unemployment", SortOrder=Convert.ToDecimal("5.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("5243b783-c099-4a5d-bc83-c1c32e363e47"), Description="Supplemental security income", SortOrder=Convert.ToDecimal("6.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("612cef86-8981-4c37-b7fd-78fba68080dd"), Description="Temporary assistance for needy families", SortOrder=Convert.ToDecimal("7.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("eb71a6e4-4d69-4453-af23-4a445e9285f7"), Description="Agricultural", SortOrder=Convert.ToDecimal("8.00") },
            new RefFamilyIncomeSource { Id=Guid.Parse("53fff00f-4abe-4153-9616-35185068fe1a"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
