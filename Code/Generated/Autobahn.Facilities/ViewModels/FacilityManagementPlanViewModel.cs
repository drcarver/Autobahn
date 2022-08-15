//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RefFacilitiesMgmtEmergencyTypeId property
        private Guid? _RefFacilitiesMgmtEmergencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityManagementPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Facilities Management Emergency Type")]
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get => _RefFacilitiesMgmtEmergencyTypeId; set => SetProperty(ref _RefFacilitiesMgmtEmergencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagementPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId; // Facilities Management Emergency Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
