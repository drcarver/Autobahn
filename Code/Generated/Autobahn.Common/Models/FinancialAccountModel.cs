//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountModel.cs
//* Name:       Financial Account Number
//* Definition: A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
     /// </summary>
    public partial class FinancialAccountModel : AutobahnBase, Interfaces.IFinancialAccount
    {
        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        public System.String AccountNumber { get; set; }

        public System.String FederalProgramCode { get; set; }

        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        public System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// Financial Expenditure K12 Project Reporting Code
        /// <para>
        /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
        /// </para>
        /// </summary>
        public System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// Financial Account Name
        /// <para>
        /// The name given to the financial account in an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
        /// </para>
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    }
}
