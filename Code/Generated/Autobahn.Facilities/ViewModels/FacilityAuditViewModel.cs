//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityAuditViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityAuditDate property
        private System.DateTime? _FacilityAuditDate;

        // member variable for the RefFacilityAuditTypeId property
        private Guid? _RefFacilityAuditTypeId;

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
        /// The title of the FacilityAuditViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.DateTime? FacilityAuditDate { get => _FacilityAuditDate; set => SetProperty(ref _FacilityAuditDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditTypeId"/> model
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
            FacilityId = model.FacilityId;
            FacilityAuditDate = model.FacilityAuditDate;
            RefFacilityAuditTypeId = model.RefFacilityAuditTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
