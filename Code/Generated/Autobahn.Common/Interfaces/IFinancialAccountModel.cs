//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAccountModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAccountModel Interface
     /// </summary>
    public partial interface IFinancialAccountModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the FinancialAccount.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.AccountNumber non nullable property
        /// </summary>
        System.String AccountNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategory"/> model
        /// </summary>
        Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassification"/> model
        /// </summary>
        Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCode"/> model
        /// </summary>
        Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureObjectCodeId { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FinancialAccountNumber non nullable property
        /// </summary>
        System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FinancialExpenditureProjectReportingCode nullable property
        /// </summary>
        System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCode"/> model
        /// </summary>
        Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FederalProgramCode non nullable property
        /// </summary>
        System.String FederalProgramCode { get; set; }

    }
}
