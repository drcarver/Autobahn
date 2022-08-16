//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _ActualValue;

        // member variable for the BudgetedValue property
        private  _BudgetedValue;

        // member variable for the Date property
        private  _Date;

        // member variable for the EncumberedValue property
        private  _EncumberedValue;

        // member variable for the FiscalPeriodBeginDate property
        private  _FiscalPeriodBeginDate;

        // member variable for the FiscalPeriodEndDate property
        private  _FiscalPeriodEndDate;

        // member variable for the FiscalYear property
        private  _FiscalYear;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Value property
        private  _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ActualValue { get => _ActualValue; set => SetProperty(ref _ActualValue, value); }

        /// <summary>
        /// </summary>
        public  BudgetedValue { get => _BudgetedValue; set => SetProperty(ref _BudgetedValue, value); }

        /// <summary>
        /// </summary>
        public  Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// </summary>
        public  EncumberedValue { get => _EncumberedValue; set => SetProperty(ref _EncumberedValue, value); }

        /// <summary>
        /// </summary>
        public  FiscalPeriodBeginDate { get => _FiscalPeriodBeginDate; set => SetProperty(ref _FiscalPeriodBeginDate, value); }

        /// <summary>
        /// </summary>
        public  FiscalPeriodEndDate { get => _FiscalPeriodEndDate; set => SetProperty(ref _FiscalPeriodEndDate, value); }

        /// <summary>
        /// </summary>
        public  FiscalYear { get => _FiscalYear; set => SetProperty(ref _FiscalYear, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualValue = model.ActualValue; // 
            BudgetedValue = model.BudgetedValue; // 
            Date = model.Date; // 
            EncumberedValue = model.EncumberedValue; // 
            FiscalPeriodBeginDate = model.FiscalPeriodBeginDate; // 
            FiscalPeriodEndDate = model.FiscalPeriodEndDate; // 
            FiscalYear = model.FiscalYear; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
