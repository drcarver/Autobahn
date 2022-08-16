//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityHazardViewModel
     /// </summary>
    public partial class FacilityHazardViewModel : ViewModelBase, Interfaces.IFacilityHazard
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityHazard";

        // member variable for the FacilityHazardousCondExpectedRemediationDate property
        private  _FacilityHazardousCondExpectedRemediationDate;

        // member variable for the FacilityLocationOfHazardousMaterials property
        private Guid? _FacilityLocationOfHazardousMaterials;

        // member variable for the FacilityNearbyEnvHazardDescription property
        private  _FacilityNearbyEnvHazardDescription;

        // member variable for the HazardousMaterialOrConditionDescription property
        private  _HazardousMaterialOrConditionDescription;

        // member variable for the HazardousMaterialOrConditionTestingDate property
        private  _HazardousMaterialOrConditionTestingDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityHazardousMaterialsOrCondTypeId property
        private  _RefFacilityHazardousMaterialsOrCondTypeId;

        // member variable for the RefFacilityNaturallyOccurringHazardTypeId property
        private  _RefFacilityNaturallyOccurringHazardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FacilityHazardousCondExpectedRemediationDate { get => _FacilityHazardousCondExpectedRemediationDate; set => SetProperty(ref _FacilityHazardousCondExpectedRemediationDate, value); }

        /// <summary>
        /// </summary>
        public Guid? FacilityLocationOfHazardousMaterials { get => _FacilityLocationOfHazardousMaterials; set => SetProperty(ref _FacilityLocationOfHazardousMaterials, value); }

        /// <summary>
        /// </summary>
        public  FacilityNearbyEnvHazardDescription { get => _FacilityNearbyEnvHazardDescription; set => SetProperty(ref _FacilityNearbyEnvHazardDescription, value); }

        /// <summary>
        /// </summary>
        public  HazardousMaterialOrConditionDescription { get => _HazardousMaterialOrConditionDescription; set => SetProperty(ref _HazardousMaterialOrConditionDescription, value); }

        /// <summary>
        /// </summary>
        public  HazardousMaterialOrConditionTestingDate { get => _HazardousMaterialOrConditionTestingDate; set => SetProperty(ref _HazardousMaterialOrConditionTestingDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityHazardousMaterialsOrCondType"/> model
        /// </summary>
        public  RefFacilityHazardousMaterialsOrCondTypeId { get => _RefFacilityHazardousMaterialsOrCondTypeId; set => SetProperty(ref _RefFacilityHazardousMaterialsOrCondTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityNaturallyOccurringHazardType"/> model
        /// </summary>
        public  RefFacilityNaturallyOccurringHazardTypeId { get => _RefFacilityNaturallyOccurringHazardTypeId; set => SetProperty(ref _RefFacilityNaturallyOccurringHazardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityHazard model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityHazardousCondExpectedRemediationDate = model.FacilityHazardousCondExpectedRemediationDate; // 
            FacilityLocationOfHazardousMaterials = model.FacilityLocationOfHazardousMaterials; // 
            FacilityNearbyEnvHazardDescription = model.FacilityNearbyEnvHazardDescription; // 
            HazardousMaterialOrConditionDescription = model.HazardousMaterialOrConditionDescription; // 
            HazardousMaterialOrConditionTestingDate = model.HazardousMaterialOrConditionTestingDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityHazardousMaterialsOrCondTypeId = model.RefFacilityHazardousMaterialsOrCondTypeId; // 
            RefFacilityNaturallyOccurringHazardTypeId = model.RefFacilityNaturallyOccurringHazardTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
