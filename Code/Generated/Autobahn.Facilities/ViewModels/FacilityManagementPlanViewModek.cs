//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementPlanViewModel
     /// </summary>
    public partial class FacilityManagementPlanViewModel : BindableBase, IFacilityManagementPlan
    {
#region "Backing Fields"
        // member variable for the FacilitiesPlanDescription property
        private System.String _FacilitiesPlanDescription;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagementId"/> model
        /// </summary>
        public Guid FacilityManagementId { get; set; }

        public System.String FacilitiesPlanDescription  { get => _FacilitiesPlanDescription; set => SetProperty(ref _FacilitiesPlanDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanTypeId"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyTypeId"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

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
        public void Load(IFacilityManagementPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityManagementId = model.FacilityManagementId;
            FacilitiesPlanDescription = model.FacilitiesPlanDescription;
            RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId;
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId;
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
