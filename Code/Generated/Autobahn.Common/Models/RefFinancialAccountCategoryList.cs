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
        public static List<RefFinancialAccountCategory> RefFinancialAccountCategoryList = new List<RefFinancialAccountCategory>
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("a3a18e06-cf94-4a7d-bc1b-64f6b7cb5aa5"), Code="Assets", Description="Assets", Definition="Asset financial account.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("f67823c9-91e9-4267-91b0-40b76d9791fe"), Code="Liabilities", Description="Liabilities", Definition="Liability financial account.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("423e6c58-6ed2-4058-8f28-29bea9ee08fb"), Code="Equity", Description="Equity", Definition="Equity (Fund Balances/Fund Net Asset) financial account.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("4abb0a83-3e4c-4beb-95aa-ce01eaab0523"), Code="Revenue", Description="Revenue and Other Financing Sources", Definition="Revenue and Other Financing Sources - Accounts for recording revenue and other receivables by source.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("f5cc78f7-cb5f-447b-8ce9-e68a2769a6a4"), Code="Expenditures", Description="Expenditures", Definition="Expenditures (Function and Object) financial account.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefFinancialAccountCategory Pick List
         /// </summary>
        public static List<RefFinancialAccountCategory> RefFinancialAccountCategoryPickList = new List<RefFinancialAccountCategory>
        {
            new RefFinancialAccountCategory { Id=Guid.Parse("a3a18e06-cf94-4a7d-bc1b-64f6b7cb5aa5"), Code="Assets", Description="Assets", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("f67823c9-91e9-4267-91b0-40b76d9791fe"), Code="Liabilities", Description="Liabilities", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("423e6c58-6ed2-4058-8f28-29bea9ee08fb"), Code="Equity", Description="Equity", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("4abb0a83-3e4c-4beb-95aa-ce01eaab0523"), Code="Revenue", Description="Revenue and Other Financing Sources", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountCategory { Id=Guid.Parse("f5cc78f7-cb5f-447b-8ce9-e68a2769a6a4"), Code="Expenditures", Description="Expenditures", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
