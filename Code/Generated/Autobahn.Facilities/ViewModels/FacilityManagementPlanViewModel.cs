//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementPlanViewModel
     /// </summary>
    public partial class FacilityManagementPlanViewModel : ViewModelBase, Interfaces.IFacilityManagementPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagementPlan";

        // member variable for the FacilitiesPlanDescription property
        private System.String _FacilitiesPlanDescription;

        // member variable for the FacilityManagementId property
        private Guid _FacilityManagementId;

        // member variable for the RefFacilitiesMgmtEmergencyTypeId property
        private Guid? _RefFacilitiesMgmtEmergencyTypeId;

        // member variable for the RefFacilitiesPlanTypeId property
        private Guid? _RefFacilitiesPlanTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityManagementPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        public System.String FacilitiesPlanDescription { get => _FacilitiesPlanDescription; set => SetProperty(ref _FacilitiesPlanDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityManagement"/> model
        /// </summary>
        public Guid FacilityManagementId { get => _FacilityManagementId; set => SetProperty(ref _FacilityManagementId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get => _RefFacilitiesMgmtEmergencyTypeId; set => SetProperty(ref _RefFacilitiesMgmtEmergencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get => _RefFacilitiesPlanTypeId; set => SetProperty(ref _RefFacilitiesPlanTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagementPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilitiesPlanDescription = model.FacilitiesPlanDescription;
            FacilityManagementId = model.FacilityManagementId;
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId;
            RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
