//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAccount.cs
//* Name:       Financial Account Number
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IFinancialAccount : IAutobahnBase
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
        System.String AccountNumber { get; set; }

        System.String FederalProgramCode { get; set; }

        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        System.String FinancialAccountNumber { get; set; }

        /// <summary>
        /// Financial Expenditure K12 Project Reporting Code
        /// <para>
        /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
        /// </para>
        /// </summary>
        System.Decimal? FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// Financial Account Name
        /// <para>
        /// The name given to the financial account in an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
        /// </para>
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAccountCategory"/> model
        /// </summary>
        Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAccountFundClassification"/> model
        /// </summary>
        Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAccountProgramCode"/> model
        /// </summary>
        Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAccountRevenueCode"/> model
        /// </summary>
        Guid? RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialExpenditureObjectCode"/> model
        /// </summary>
        Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    }
}
