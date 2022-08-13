//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityAuditViewModel
     /// </summary>
    public partial class FacilityAuditViewModel : ViewModelBase, Interfaces.IFacilityAudit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityAudit";

        // member variable for the FacilityAuditDate property
        private System.DateTime? _FacilityAuditDate;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the RefFacilityAuditTypeId property
        private Guid? _RefFacilityAuditTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityAuditViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        public System.DateTime? FacilityAuditDate { get => _FacilityAuditDate; set => SetProperty(ref _FacilityAuditDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditType"/> model
        /// </summary>
        public Guid? RefFacilityAuditTypeId { get => _RefFacilityAuditTypeId; set => SetProperty(ref _RefFacilityAuditTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityAudit model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityAuditDate = model.FacilityAuditDate;
            FacilityId = model.FacilityId;
            RefFacilityAuditTypeId = model.RefFacilityAuditTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
