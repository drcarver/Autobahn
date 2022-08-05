//**********************************************************
//* DomainName: Autobahn.Common
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

        // member variable for the FinancialAccountId property
        private Guid _FinancialAccountId;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the ActualValue property
        private System.Decimal? _ActualValue;

        // member variable for the BudgetedValue property
        private System.Decimal? _BudgetedValue;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the EncumberedValue property
        private System.Decimal? _EncumberedValue;

        // member variable for the Value property
        private System.Decimal? _Value;

        // member variable for the FiscalPeriodBeginDate property
        private System.DateTime? _FiscalPeriodBeginDate;

        // member variable for the FiscalPeriodEndDate property
        private System.DateTime? _FiscalPeriodEndDate;

        // member variable for the FiscalYear property
        private System.String _FiscalYear;

        // member variable for the FinancialAccountProgramId property
        private Guid? _FinancialAccountProgramId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFinancialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FinancialAccountId"/> model
        /// </summary>
        public Guid FinancialAccountId { get => _FinancialAccountId; set => SetProperty(ref _FinancialAccountId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        public System.Decimal? ActualValue { get => _ActualValue; set => SetProperty(ref _ActualValue, value); }

        public System.Decimal? BudgetedValue { get => _BudgetedValue; set => SetProperty(ref _BudgetedValue, value); }

        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        public System.Decimal? EncumberedValue { get => _EncumberedValue; set => SetProperty(ref _EncumberedValue, value); }

        public System.Decimal? Value { get => _Value; set => SetProperty(ref _Value, value); }

        public System.DateTime? FiscalPeriodBeginDate { get => _FiscalPeriodBeginDate; set => SetProperty(ref _FiscalPeriodBeginDate, value); }

        public System.DateTime? FiscalPeriodEndDate { get => _FiscalPeriodEndDate; set => SetProperty(ref _FiscalPeriodEndDate, value); }

        public System.String FiscalYear  { get => _FiscalYear; set => SetProperty(ref _FiscalYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FinancialAccountProgramId"/> model
        /// </summary>
        public Guid? FinancialAccountProgramId { get => _FinancialAccountProgramId; set => SetProperty(ref _FinancialAccountProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAccountId = model.FinancialAccountId;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            ActualValue = model.ActualValue;
            BudgetedValue = model.BudgetedValue;
            Date = model.Date;
            EncumberedValue = model.EncumberedValue;
            Value = model.Value;
            FiscalPeriodBeginDate = model.FiscalPeriodBeginDate;
            FiscalPeriodEndDate = model.FiscalPeriodEndDate;
            FiscalYear = model.FiscalYear;
            FinancialAccountProgramId = model.FinancialAccountProgramId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
