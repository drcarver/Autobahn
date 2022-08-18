//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementPlan View Model
     /// </summary>
    public partial class FacilityManagementPlanViewModel : ViewModelBase, Interfaces.IFacilityManagementPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagementPlan";

        // FacilitiesPlanDescription -- (backing property for Facilities Plan Description)
        private System.String _FacilitiesPlanDescription;

        // member variable for the FacilityManagementId property
        private Guid _FacilityManagementId;

        // RefFacilitiesMgmtEmergencyTypeId -- (backing property for Facilities Management Emergency Type)
        private Guid? _RefFacilitiesMgmtEmergencyTypeId;

        // RefFacilitiesPlanTypeId -- (backing property for Facilities Plan Type)
        private Guid? _RefFacilitiesPlanTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Facilities Plan Description
        /// <para>
        /// A description of the management and accountability plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20863">Facilities Plan Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilitiesPlanDescription { get => _FacilitiesPlanDescription; set => SetProperty(ref _FacilitiesPlanDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
        /// </summary>
        public Guid FacilityManagementId { get => _FacilityManagementId; set => SetProperty(ref _FacilityManagementId, value); }

        /// <summary>
        /// Facilities Management Emergency Type
        /// <para>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get => _RefFacilitiesMgmtEmergencyTypeId; set => SetProperty(ref _RefFacilitiesMgmtEmergencyTypeId, value); }

        /// <summary>
        /// Facilities Plan Type
        /// <para>
        /// The type of management and accountability plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
        /// </para>
        /// </summary>
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
            FacilitiesPlanDescription = model.FacilitiesPlanDescription; // Facilities Plan Description
            FacilityManagementId = model.FacilityManagementId; // 
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId; // Facilities Management Emergency Type
            RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId; // Facilities Plan Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
