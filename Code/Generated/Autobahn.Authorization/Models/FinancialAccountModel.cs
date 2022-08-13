//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   FinancialAccountModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The FinancialAccount Model
     /// </summary>
    public partial class FinancialAccountModel : AutobahnBase, Interfaces.IFinancialAccount
    {
        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String AccountNumber { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String FederalProgramCode { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    }
}
