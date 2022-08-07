//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityRelationshipViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityRelationshipViewModel
     /// </summary>
    public partial class FacilityRelationshipViewModel : ViewModelBase, Interfaces.IFacilityRelationshipViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityRelationship";

        // member variable for the Parent_FacilityId property
        private Guid _Parent_FacilityId;

        // member variable for the FacilityId property
        private Guid _FacilityId;

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
        /// The title of the FacilityRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="Parent_FacilityId"/> model
        /// </summary>
        public Guid Parent_FacilityId { get => _Parent_FacilityId; set => SetProperty(ref _Parent_FacilityId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            Parent_FacilityId = model.Parent_FacilityId;
            FacilityId = model.FacilityId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
