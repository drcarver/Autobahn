//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialViewModel.cs
//* Name:       Financial Accounting Period Actual Value
//* Definition: The actual value of a financial account for the specified accounting period or fiscal year.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The actual value of a financial account for the specified accounting period or fiscal year.
     /// </summary>
    public partial class OrganizationFinancialViewModel : ViewModelBase, Interfaces.IOrganizationFinancial
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFinancial";

        // ActualValue -- (backing property for Financial Accounting Period Actual Value)
        private System.Decimal? _ActualValue;

        // BudgetedValue -- (backing property for Financial Accounting Period Budgeted Value)
        private System.Decimal? _BudgetedValue;

        // Date -- (backing property for Financial Accounting Date)
        private System.DateTime? _Date;

        // EncumberedValue -- (backing property for Financial Accounting Period Encumbered Value)
        private System.Decimal? _EncumberedValue;

        // member variable for the FinancialAccountId property
        private Guid _FinancialAccountId;

        // member variable for the FinancialAccountProgramId property
        private Guid? _FinancialAccountProgramId;

        // FiscalPeriodBeginDate -- (backing property for Fiscal Period Begin Date)
        private System.DateTime? _FiscalPeriodBeginDate;

        // FiscalPeriodEndDate -- (backing property for Fiscal Period End Date)
        private System.DateTime? _FiscalPeriodEndDate;

        // FiscalYear -- (backing property for Fiscal Year)
        private System.String _FiscalYear;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // Value -- (backing property for Financial Accounting Value)
        private System.Decimal? _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Financial Accounting Period Actual Value
        /// <para>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ActualValue { get => _ActualValue; set => SetProperty(ref _ActualValue, value); }

        /// <summary>
        /// Financial Accounting Period Budgeted Value
        /// <para>
        /// The budgeted value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? BudgetedValue { get => _BudgetedValue; set => SetProperty(ref _BudgetedValue, value); }

        /// <summary>
        /// Financial Accounting Date
        /// <para>
        /// The date of a financial transaction or when an account balance is reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Financial Accounting Period Encumbered Value
        /// <para>
        /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? EncumberedValue { get => _EncumberedValue; set => SetProperty(ref _EncumberedValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFinancialAccount"/> model
        /// </summary>
        public Guid FinancialAccountId { get => _FinancialAccountId; set => SetProperty(ref _FinancialAccountId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> model
        /// </summary>
        public Guid? FinancialAccountProgramId { get => _FinancialAccountProgramId; set => SetProperty(ref _FinancialAccountProgramId, value); }

        /// <summary>
        /// Fiscal Period Begin Date
        /// <para>
        /// The year, month and day on which an accounting period begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20623">Fiscal Period Begin Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FiscalPeriodBeginDate { get => _FiscalPeriodBeginDate; set => SetProperty(ref _FiscalPeriodBeginDate, value); }

        /// <summary>
        /// Fiscal Period End Date
        /// <para>
        /// The year, month and day on which an accounting period ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FiscalPeriodEndDate { get => _FiscalPeriodEndDate; set => SetProperty(ref _FiscalPeriodEndDate, value); }

        /// <summary>
        /// Fiscal Year
        /// <para>
        /// The year a school uses for budgeting, accounting, and reporting financials.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20620">Fiscal Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FiscalYear { get => _FiscalYear; set => SetProperty(ref _FiscalYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Financial Accounting Value
        /// <para>
        /// The value of a financial account balance or transaction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20628">Financial Accounting Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualValue = model.ActualValue; // Financial Accounting Period Actual Value
            BudgetedValue = model.BudgetedValue; // Financial Accounting Period Budgeted Value
            Date = model.Date; // Financial Accounting Date
            EncumberedValue = model.EncumberedValue; // Financial Accounting Period Encumbered Value
            FinancialAccountId = model.FinancialAccountId; // 
            FinancialAccountProgramId = model.FinancialAccountProgramId; // 
            FiscalPeriodBeginDate = model.FiscalPeriodBeginDate; // Fiscal Period Begin Date
            FiscalPeriodEndDate = model.FiscalPeriodEndDate; // Fiscal Period End Date
            FiscalYear = model.FiscalYear; // Fiscal Year
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            Value = model.Value; // Financial Accounting Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
