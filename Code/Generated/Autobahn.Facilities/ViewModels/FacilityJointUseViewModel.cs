//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingJointUseRationaleTypeId property
        private Guid? _RefBuildingJointUseRationaleTypeId;

        // member variable for the RefBuildingJointUserTypeId property
        private  _RefBuildingJointUserTypeId;

        // member variable for the RefBuildingJointUseSchedulingTypeId property
        private  _RefBuildingJointUseSchedulingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleType"/> model
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get => _RefBuildingJointUseRationaleTypeId; set => SetProperty(ref _RefBuildingJointUseRationaleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUserType"/> model
        /// </summary>
        public  RefBuildingJointUserTypeId { get => _RefBuildingJointUserTypeId; set => SetProperty(ref _RefBuildingJointUserTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseSchedulingType"/> model
        /// </summary>
        public  RefBuildingJointUseSchedulingTypeId { get => _RefBuildingJointUseSchedulingTypeId; set => SetProperty(ref _RefBuildingJointUseSchedulingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityJointUse model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId; // 
            RefBuildingJointUserTypeId = model.RefBuildingJointUserTypeId; // 
            RefBuildingJointUseSchedulingTypeId = model.RefBuildingJointUseSchedulingTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
