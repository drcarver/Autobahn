//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityHazardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityHazardousCondExpectedRemediationDate property
        private System.DateTime? _FacilityHazardousCondExpectedRemediationDate;

        // member variable for the FacilityLocationOfHazardousMaterials property
        private System.String _FacilityLocationOfHazardousMaterials;

        // member variable for the FacilityNearbyEnvHazardDescription property
        private System.String _FacilityNearbyEnvHazardDescription;

        // member variable for the HazardousMaterialOrConditionDescription property
        private System.String _HazardousMaterialOrConditionDescription;

        // member variable for the HazardousMaterialOrConditionTestingDate property
        private System.DateTime? _HazardousMaterialOrConditionTestingDate;

        // member variable for the RefFacilityHazardousMaterialsOrCondTypeId property
        private Guid? _RefFacilityHazardousMaterialsOrCondTypeId;

        // member variable for the RefFacilityNaturallyOccurringHazardTypeId property
        private Guid? _RefFacilityNaturallyOccurringHazardTypeId;

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
        /// The title of the FacilityHazardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.DateTime? FacilityHazardousCondExpectedRemediationDate { get => _FacilityHazardousCondExpectedRemediationDate; set => SetProperty(ref _FacilityHazardousCondExpectedRemediationDate, value); }

        public System.String FacilityLocationOfHazardousMaterials  { get => _FacilityLocationOfHazardousMaterials; set => SetProperty(ref _FacilityLocationOfHazardousMaterials, value); }

        public System.String FacilityNearbyEnvHazardDescription  { get => _FacilityNearbyEnvHazardDescription; set => SetProperty(ref _FacilityNearbyEnvHazardDescription, value); }

        public System.String HazardousMaterialOrConditionDescription  { get => _HazardousMaterialOrConditionDescription; set => SetProperty(ref _HazardousMaterialOrConditionDescription, value); }

        public System.DateTime? HazardousMaterialOrConditionTestingDate { get => _HazardousMaterialOrConditionTestingDate; set => SetProperty(ref _HazardousMaterialOrConditionTestingDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityHazardousMaterialsOrCondTypeId"/> model
        /// </summary>
        public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get => _RefFacilityHazardousMaterialsOrCondTypeId; set => SetProperty(ref _RefFacilityHazardousMaterialsOrCondTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityNaturallyOccurringHazardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityNaturallyOccurringHazardTypeId { get => _RefFacilityNaturallyOccurringHazardTypeId; set => SetProperty(ref _RefFacilityNaturallyOccurringHazardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityHazard model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityHazardousCondExpectedRemediationDate = model.FacilityHazardousCondExpectedRemediationDate;
            FacilityLocationOfHazardousMaterials = model.FacilityLocationOfHazardousMaterials;
            FacilityNearbyEnvHazardDescription = model.FacilityNearbyEnvHazardDescription;
            HazardousMaterialOrConditionDescription = model.HazardousMaterialOrConditionDescription;
            HazardousMaterialOrConditionTestingDate = model.HazardousMaterialOrConditionTestingDate;
            RefFacilityHazardousMaterialsOrCondTypeId = model.RefFacilityHazardousMaterialsOrCondTypeId;
            RefFacilityNaturallyOccurringHazardTypeId = model.RefFacilityNaturallyOccurringHazardTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
