//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinanceViewModel
     /// </summary>
    public partial class FacilityFinanceViewModel : ViewModelBase, Interfaces.IFacilityFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityFinance";

        // member variable for the FacilityReplacementValue property
        private Guid? _FacilityReplacementValue;

        // member variable for the IndebtednessAmountAllowed property
        private  _IndebtednessAmountAllowed;

        // member variable for the InsuranceDeductible property
        private  _InsuranceDeductible;

        // member variable for the PublicEducationMillRate property
        private  _PublicEducationMillRate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilityReplacementValue { get => _FacilityReplacementValue; set => SetProperty(ref _FacilityReplacementValue, value); }

        /// <summary>
        /// </summary>
        public  IndebtednessAmountAllowed { get => _IndebtednessAmountAllowed; set => SetProperty(ref _IndebtednessAmountAllowed, value); }

        /// <summary>
        /// </summary>
        public  InsuranceDeductible { get => _InsuranceDeductible; set => SetProperty(ref _InsuranceDeductible, value); }

        /// <summary>
        /// </summary>
        public  PublicEducationMillRate { get => _PublicEducationMillRate; set => SetProperty(ref _PublicEducationMillRate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityReplacementValue = model.FacilityReplacementValue; // 
            IndebtednessAmountAllowed = model.IndebtednessAmountAllowed; // 
            InsuranceDeductible = model.InsuranceDeductible; // 
            PublicEducationMillRate = model.PublicEducationMillRate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
