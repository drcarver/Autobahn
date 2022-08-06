//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountCategory"> List
         /// </summary>
        public static List<RefFinancialAccountCategory> RefFinancialAccountCategoryList = new List<RefFinancialAccountCategory> =
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("2671b519-2524-41f4-9aeb-8a7d95b6eb81"), Code="Asset financial account.", Description="Assets", Definition="", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("c7062b7c-342d-4a0b-9cd2-34345e3b1f67"), Code="Liability financial account.", Description="Liabilities", Definition="", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("376a561f-4ecf-4215-8fad-00c5e5ee9f5a"), Code="Equity (Fund Balances/Fund Net Asset) financial account.", Description="Equity", Definition="", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("bf62c675-f154-4fd5-ac6f-49e2d6b36d09"), Code="Revenue and Other Financing Sources - Accounts for recording revenue and other receivables by source.", Description="Revenue", Definition="", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("4a7c3bff-d67b-4f23-bf24-4a6d6427567a"), Code="Expenditures (Function and Object) financial account.", Description="Expenditures", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFinancialAccountCategory Pick List
         /// </summary>
        public static List<RefFinancialAccountCategory> RefFinancialAccountCategoryPickList = new List<RefFinancialAccountCategory> =
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("2671b519-2524-41f4-9aeb-8a7d95b6eb81"), Code="Asset financial account.", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("c7062b7c-342d-4a0b-9cd2-34345e3b1f67"), Code="Liability financial account.", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("376a561f-4ecf-4215-8fad-00c5e5ee9f5a"), Code="Equity (Fund Balances/Fund Net Asset) financial account.", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("bf62c675-f154-4fd5-ac6f-49e2d6b36d09"), Code="Revenue and Other Financing Sources - Accounts for recording revenue and other receivables by source.", SortOrder=0 },
            new RefFinancialAccountCategory { Id=Guid.Parse("4a7c3bff-d67b-4f23-bf24-4a6d6427567a"), Code="Expenditures (Function and Object) financial account.", SortOrder=0 },
       };
   }
}
