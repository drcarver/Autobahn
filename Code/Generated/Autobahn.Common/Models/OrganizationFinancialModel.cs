//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialModel.cs
//* Name:       Financial Accounting Period Actual Value
//* Definition: The actual value of a financial account for the specified accounting period or fiscal year.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The actual value of a financial account for the specified accounting period or fiscal year.
     /// </summary>
    public partial class OrganizationFinancialModel : AutobahnBase, Interfaces.IOrganizationFinancial
    {
        /// <summary>
        /// Financial Accounting Period Actual Value
        /// <para>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? ActualValue { get; set; }

        /// <summary>
        /// Financial Accounting Period Budgeted Value
        /// <para>
        /// The budgeted value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// Financial Accounting Date
        /// <para>
        /// The date of a financial transaction or when an account balance is reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Financial Accounting Period Encumbered Value
        /// <para>
        /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> model
        /// </summary>
        public Guid? FinancialAccountProgramId { get; set; }

        /// <summary>
        /// Fiscal Period Begin Date
        /// <para>
        /// The year, month and day on which an accounting period begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20623">Fiscal Period Begin Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// Fiscal Period End Date
        /// <para>
        /// The year, month and day on which an accounting period ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// Fiscal Year
        /// <para>
        /// The year a school uses for budgeting, accounting, and reporting financials.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20620">Fiscal Year</a>
        /// </para>
        /// </summary>
        public System.String FiscalYear { get; set; }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Financial Accounting Value
        /// <para>
        /// The value of a financial account balance or transaction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20628">Financial Accounting Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? Value { get; set; }

    }
}
