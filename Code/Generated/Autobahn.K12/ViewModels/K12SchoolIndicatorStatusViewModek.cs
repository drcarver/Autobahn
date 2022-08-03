//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolIndicatorStatusViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolIndicatorStatusViewModel
     /// </summary>
    public partial class K12SchoolIndicatorStatusViewModel : BindableBase, IK12SchoolIndicatorStatus
    {
#region "Backing Fields"
        // member variable for the IndicatorStatusSubgroup property
        private System.String _IndicatorStatusSubgroup;

        // member variable for the IndicatorStatus property
        private System.String _IndicatorStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStatusTypeId"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatusId"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupTypeId"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        public System.String IndicatorStatusSubgroup  { get => _IndicatorStatusSubgroup; set => SetProperty(ref _IndicatorStatusSubgroup, value); }

        public System.String IndicatorStatus  { get => _IndicatorStatus; set => SetProperty(ref _IndicatorStatus, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomTypeId"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

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
        public void Load(IK12SchoolIndicatorStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefIndicatorStatusTypeId = model.RefIndicatorStatusTypeId;
            RefIndicatorStateDefinedStatusId = model.RefIndicatorStateDefinedStatusId;
            RefIndicatorStatusSubgroupTypeId = model.RefIndicatorStatusSubgroupTypeId;
            IndicatorStatusSubgroup = model.IndicatorStatusSubgroup;
            IndicatorStatus = model.IndicatorStatus;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefIndicatorStatusCustomTypeId = model.RefIndicatorStatusCustomTypeId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
