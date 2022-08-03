//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityHazardViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityHazardViewModel
     /// </summary>
    public partial class FacilityHazardViewModel : BindableBase, IFacilityHazard
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        public System.DateTime? FacilityHazardousCondExpectedRemediationDate { get => _FacilityHazardousCondExpectedRemediationDate; set => SetProperty(ref _FacilityHazardousCondExpectedRemediationDate, value); }

        public System.String FacilityLocationOfHazardousMaterials  { get => _FacilityLocationOfHazardousMaterials; set => SetProperty(ref _FacilityLocationOfHazardousMaterials, value); }

        public System.String FacilityNearbyEnvHazardDescription  { get => _FacilityNearbyEnvHazardDescription; set => SetProperty(ref _FacilityNearbyEnvHazardDescription, value); }

        public System.String HazardousMaterialOrConditionDescription  { get => _HazardousMaterialOrConditionDescription; set => SetProperty(ref _HazardousMaterialOrConditionDescription, value); }

        public System.DateTime? HazardousMaterialOrConditionTestingDate { get => _HazardousMaterialOrConditionTestingDate; set => SetProperty(ref _HazardousMaterialOrConditionTestingDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityHazardousMaterialsOrCondTypeId"/> model
        /// </summary>
        public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityNaturallyOccurringHazardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

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
        public void Load(IFacilityHazard model)
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
