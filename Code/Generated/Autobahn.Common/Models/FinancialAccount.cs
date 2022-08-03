//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccount.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAccount
     /// </summary>
    public partial class FinancialAccount : IFinancialAccount
    {
        /// <summary>
        /// Defines the FinancialAccount.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.AccountNumber non nullable property
        /// </summary>
        public System.String AccountNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategory"/> model
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassification"/> model
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FinancialAccountNumber non nullable property
        /// </summary>
        public System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FinancialExpenditureProjectReportingCode nullable property
        /// </summary>
        public System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.FederalProgramCode non nullable property
        /// </summary>
        public System.String FederalProgramCode { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAccount.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
