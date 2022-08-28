//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The OrganizationFinancial Model
     /// </summary>
    public partial class OrganizationFinancialModel : IOrganizationFinancial
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IOrganizationFinancial
        /// <summary>
        /// Financial Accounting Period Actual Value
        /// <para>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
        /// </summary>
        public Decimal? ActualValue { get; set; }

        /// <summary>
        /// Financial Accounting Period Budgeted Value
        /// <para>
        /// The budgeted value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
        /// </para>
        /// </summary>
        public Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// Financial Accounting Date
        /// <para>
        /// The date of a financial transaction or when an account balance is reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Financial Accounting Period Encumbered Value
        /// <para>
        /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
        /// </para>
        /// </summary>
        public Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFinancialAccount"/> model
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
        public DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// Fiscal Period End Date
        /// <para>
        /// The year, month and day on which an accounting period ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
        /// </para>
        /// </summary>
        public DateTime? FiscalPeriodEndDate { get; set; }

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
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
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
        public Decimal? Value { get; set; }

        #endregion
    }
}
