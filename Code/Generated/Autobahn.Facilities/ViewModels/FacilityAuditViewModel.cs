//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _FacilityAuditDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityAuditTypeId property
        private Guid? _RefFacilityAuditTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FacilityAuditDate { get => _FacilityAuditDate; set => SetProperty(ref _FacilityAuditDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

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
            FacilityAuditDate = model.FacilityAuditDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityAuditTypeId = model.RefFacilityAuditTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
