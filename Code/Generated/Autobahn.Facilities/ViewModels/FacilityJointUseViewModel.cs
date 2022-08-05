//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityJointUseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityJointUseViewModel
     /// </summary>
    public partial class FacilityJointUseViewModel : ViewModelBase, Interfaces.IFacilityJointUse
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityJointUse";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the RefBuildingJointUseRationaleTypeId property
        private Guid? _RefBuildingJointUseRationaleTypeId;

        // member variable for the RefBuildingJointUserTypeId property
        private Guid? _RefBuildingJointUserTypeId;

        // member variable for the RefBuildingJointUseSchedulingTypeId property
        private Guid? _RefBuildingJointUseSchedulingTypeId;

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
        /// The title of the FacilityJointUseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get => _RefBuildingJointUseRationaleTypeId; set => SetProperty(ref _RefBuildingJointUseRationaleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUserTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUserTypeId { get => _RefBuildingJointUserTypeId; set => SetProperty(ref _RefBuildingJointUserTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseSchedulingTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUseSchedulingTypeId { get => _RefBuildingJointUseSchedulingTypeId; set => SetProperty(ref _RefBuildingJointUseSchedulingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityJointUse model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId;
            RefBuildingJointUserTypeId = model.RefBuildingJointUserTypeId;
            RefBuildingJointUseSchedulingTypeId = model.RefBuildingJointUseSchedulingTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
