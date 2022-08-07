//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountCategoryList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountCategoryModel"> List
         /// </summary>
        public static List<RefFinancialAccountCategoryModel> RefFinancialAccountCategoryList = new List<RefFinancialAccountCategoryModel>
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("18842a96-e9c6-4991-9d7a-aee405fb439c"), Code="Assets", Description="Assets", Definition="Asset financial account.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("8222af83-819f-466a-b42c-2d82b4555ee7"), Code="Liabilities", Description="Liabilities", Definition="Liability financial account.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("e46d0a61-e1b7-4e91-8203-d250925f70a5"), Code="Equity", Description="Equity", Definition="Equity (Fund Balances/Fund Net Asset) financial account.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("41fa78cb-c579-4844-97f5-cda356fad1a1"), Code="Revenue", Description="Revenue and Other Financing Sources", Definition="Revenue and Other Financing Sources - Accounts for recording revenue and other receivables by source.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("3a5ce348-6027-4ca8-b12b-fb1367fd926c"), Code="Expenditures", Description="Expenditures", Definition="Expenditures (Function and Object) financial account.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAccountCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAccountCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("18842a96-e9c6-4991-9d7a-aee405fb439c"), Description="Assets", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("8222af83-819f-466a-b42c-2d82b4555ee7"), Description="Liabilities", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("e46d0a61-e1b7-4e91-8203-d250925f70a5"), Description="Equity", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("41fa78cb-c579-4844-97f5-cda356fad1a1"), Description="Revenue and Other Financing Sources", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("3a5ce348-6027-4ca8-b12b-fb1367fd926c"), Description="Expenditures", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
