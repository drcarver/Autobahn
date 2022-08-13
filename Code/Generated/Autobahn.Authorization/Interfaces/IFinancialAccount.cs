//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IFinancialAccount.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IFinancialAccount Interface
     /// </summary>
    public partial interface IFinancialAccount : IAutobahnBase
    {
        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        System.String AccountNumber { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        System.String FederalProgramCode { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    }
}
