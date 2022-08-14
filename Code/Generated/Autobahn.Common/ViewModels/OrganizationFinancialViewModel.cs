//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFinancialViewModel
     /// </summary>
    public partial class OrganizationFinancialViewModel : ViewModelBase, Interfaces.IOrganizationFinancial
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFinancial";

        // member variable for the ActualValue property
        private System.Decimal? _ActualValue;

        // member variable for the BudgetedValue property
        private System.Decimal? _BudgetedValue;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the EncumberedValue property
        private System.Decimal? _EncumberedValue;

        // member variable for the FinancialAccountId property
        private Guid _FinancialAccountId;

        // member variable for the FinancialAccountProgramId property
        private Guid? _FinancialAccountProgramId;

        // member variable for the FiscalPeriodBeginDate property
        private System.DateTime? _FiscalPeriodBeginDate;

        // member variable for the FiscalPeriodEndDate property
        private System.DateTime? _FiscalPeriodEndDate;

        // member variable for the FiscalYear property
        private System.String _FiscalYear;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the Value property
        private System.Decimal? _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFinancialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? ActualValue { get => _ActualValue; set => SetProperty(ref _ActualValue, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? BudgetedValue { get => _BudgetedValue; set => SetProperty(ref _BudgetedValue, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? EncumberedValue { get => _EncumberedValue; set => SetProperty(ref _EncumberedValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FinancialAccount"/> model
        /// </summary>
        public Guid FinancialAccountId { get => _FinancialAccountId; set => SetProperty(ref _FinancialAccountId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FinancialAccountProgram"/> model
        /// </summary>
        public Guid? FinancialAccountProgramId { get => _FinancialAccountProgramId; set => SetProperty(ref _FinancialAccountProgramId, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? FiscalPeriodBeginDate { get => _FiscalPeriodBeginDate; set => SetProperty(ref _FiscalPeriodBeginDate, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? FiscalPeriodEndDate { get => _FiscalPeriodEndDate; set => SetProperty(ref _FiscalPeriodEndDate, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.String FiscalYear { get => _FiscalYear; set => SetProperty(ref _FiscalYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
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
            ActualValue = model.ActualValue;
            BudgetedValue = model.BudgetedValue;
            Date = model.Date;
            EncumberedValue = model.EncumberedValue;
            FinancialAccountId = model.FinancialAccountId;
            FinancialAccountProgramId = model.FinancialAccountProgramId;
            FiscalPeriodBeginDate = model.FiscalPeriodBeginDate;
            FiscalPeriodEndDate = model.FiscalPeriodEndDate;
            FiscalYear = model.FiscalYear;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
