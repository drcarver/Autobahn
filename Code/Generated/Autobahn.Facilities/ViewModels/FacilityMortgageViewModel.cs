//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageViewModel
     /// </summary>
    public partial class FacilityMortgageViewModel : ViewModelBase, Interfaces.IFacilityMortgage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgage";

        // member variable for the FacilityMortgageInterestAmount property
        private Guid? _FacilityMortgageInterestAmount;

        // member variable for the FacilityTotalAssessedValue property
        private  _FacilityTotalAssessedValue;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityMortgageInterestTypeId property
        private  _RefFacilityMortgageInterestTypeId;

        // member variable for the RefFacilityMortgageTypeId property
        private  _RefFacilityMortgageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        /// <summary>
        /// </summary>
        public  FacilityTotalAssessedValue { get => _FacilityTotalAssessedValue; set => SetProperty(ref _FacilityTotalAssessedValue, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestType"/> model
        /// </summary>
        public  RefFacilityMortgageInterestTypeId { get => _RefFacilityMortgageInterestTypeId; set => SetProperty(ref _RefFacilityMortgageInterestTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageType"/> model
        /// </summary>
        public  RefFacilityMortgageTypeId { get => _RefFacilityMortgageTypeId; set => SetProperty(ref _RefFacilityMortgageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgage model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount; // 
            FacilityTotalAssessedValue = model.FacilityTotalAssessedValue; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId; // 
            RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
