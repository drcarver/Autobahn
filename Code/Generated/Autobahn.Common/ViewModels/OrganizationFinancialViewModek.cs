//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFinancialViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFinancialViewModel
     /// </summary>
    public partial class OrganizationFinancialViewModel : BindableBase, IOrganizationFinancial
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FinancialAccountId"/> model
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

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
        public Guid? FinancialAccountProgramId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IOrganizationFinancial model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
