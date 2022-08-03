//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityJointUseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityJointUseViewModel
     /// </summary>
    public partial class FacilityJointUseViewModel : BindableBase, IFacilityJointUse
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUserTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseSchedulingTypeId"/> model
        /// </summary>
        public Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFacilityJointUse model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId;
            RefBuildingJointUserTypeId = model.RefBuildingJointUserTypeId;
            RefBuildingJointUseSchedulingTypeId = model.RefBuildingJointUseSchedulingTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
