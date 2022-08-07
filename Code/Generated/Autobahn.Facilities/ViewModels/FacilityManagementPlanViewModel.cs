//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementPlanViewModel
     /// </summary>
    public partial class FacilityManagementPlanViewModel : ViewModelBase, Interfaces.IFacilityManagementPlanViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagementPlan";

        // member variable for the FacilityManagementId property
        private Guid _FacilityManagementId;

        // member variable for the FacilitiesPlanDescription property
        private System.String _FacilitiesPlanDescription;

        // member variable for the RefFacilitiesPlanTypeId property
        private Guid? _RefFacilitiesPlanTypeId;

        // member variable for the RefFacilitiesMgmtEmergencyTypeId property
        private Guid? _RefFacilitiesMgmtEmergencyTypeId;

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
        /// The title of the FacilityManagementPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagementId"/> model
        /// </summary>
        public Guid FacilityManagementId { get => _FacilityManagementId; set => SetProperty(ref _FacilityManagementId, value); }

        public System.String FacilitiesPlanDescription  { get => _FacilitiesPlanDescription; set => SetProperty(ref _FacilitiesPlanDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanTypeId"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get => _RefFacilitiesPlanTypeId; set => SetProperty(ref _RefFacilitiesPlanTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyTypeId"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get => _RefFacilitiesMgmtEmergencyTypeId; set => SetProperty(ref _RefFacilitiesMgmtEmergencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagementPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityManagementId = model.FacilityManagementId;
            FacilitiesPlanDescription = model.FacilitiesPlanDescription;
            RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId;
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
