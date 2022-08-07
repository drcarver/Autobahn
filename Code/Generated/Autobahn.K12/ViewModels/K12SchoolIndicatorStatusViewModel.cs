//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolIndicatorStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolIndicatorStatusViewModel
     /// </summary>
    public partial class K12SchoolIndicatorStatusViewModel : ViewModelBase, Interfaces.IK12SchoolIndicatorStatusViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolIndicatorStatus";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the RefIndicatorStatusTypeId property
        private Guid _RefIndicatorStatusTypeId;

        // member variable for the RefIndicatorStateDefinedStatusId property
        private Guid? _RefIndicatorStateDefinedStatusId;

        // member variable for the RefIndicatorStatusSubgroupTypeId property
        private Guid? _RefIndicatorStatusSubgroupTypeId;

        // member variable for the IndicatorStatusSubgroup property
        private System.String _IndicatorStatusSubgroup;

        // member variable for the IndicatorStatus property
        private System.String _IndicatorStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefIndicatorStatusCustomTypeId property
        private Guid? _RefIndicatorStatusCustomTypeId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12SchoolIndicatorStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStatusTypeId"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get => _RefIndicatorStatusTypeId; set => SetProperty(ref _RefIndicatorStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatusId"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get => _RefIndicatorStateDefinedStatusId; set => SetProperty(ref _RefIndicatorStateDefinedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupTypeId"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get => _RefIndicatorStatusSubgroupTypeId; set => SetProperty(ref _RefIndicatorStatusSubgroupTypeId, value); }

        public System.String IndicatorStatusSubgroup  { get => _IndicatorStatusSubgroup; set => SetProperty(ref _IndicatorStatusSubgroup, value); }

        public System.String IndicatorStatus  { get => _IndicatorStatus; set => SetProperty(ref _IndicatorStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomTypeId"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get => _RefIndicatorStatusCustomTypeId; set => SetProperty(ref _RefIndicatorStatusCustomTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolIndicatorStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefIndicatorStatusTypeId = model.RefIndicatorStatusTypeId;
            RefIndicatorStateDefinedStatusId = model.RefIndicatorStateDefinedStatusId;
            RefIndicatorStatusSubgroupTypeId = model.RefIndicatorStatusSubgroupTypeId;
            IndicatorStatusSubgroup = model.IndicatorStatusSubgroup;
            IndicatorStatus = model.IndicatorStatus;
            RefIndicatorStatusCustomTypeId = model.RefIndicatorStatusCustomTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
