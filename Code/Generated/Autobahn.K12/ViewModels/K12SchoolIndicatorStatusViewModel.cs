//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolIndicatorStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolIndicatorStatusViewModel
     /// </summary>
    public partial class K12SchoolIndicatorStatusViewModel : ViewModelBase, Interfaces.IK12SchoolIndicatorStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolIndicatorStatus";

        // member variable for the IndicatorStatus property
        private System.String _IndicatorStatus;

        // member variable for the IndicatorStatusSubgroup property
        private System.String _IndicatorStatusSubgroup;

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the RefIndicatorStateDefinedStatusId property
        private Guid? _RefIndicatorStateDefinedStatusId;

        // member variable for the RefIndicatorStatusCustomTypeId property
        private Guid? _RefIndicatorStatusCustomTypeId;

        // member variable for the RefIndicatorStatusSubgroupTypeId property
        private Guid? _RefIndicatorStatusSubgroupTypeId;

        // member variable for the RefIndicatorStatusTypeId property
        private Guid _RefIndicatorStatusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SchoolIndicatorStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String IndicatorStatus { get => _IndicatorStatus; set => SetProperty(ref _IndicatorStatus, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String IndicatorStatusSubgroup { get => _IndicatorStatusSubgroup; set => SetProperty(ref _IndicatorStatusSubgroup, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get => _RefIndicatorStateDefinedStatusId; set => SetProperty(ref _RefIndicatorStateDefinedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get => _RefIndicatorStatusCustomTypeId; set => SetProperty(ref _RefIndicatorStatusCustomTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get => _RefIndicatorStatusSubgroupTypeId; set => SetProperty(ref _RefIndicatorStatusSubgroupTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get => _RefIndicatorStatusTypeId; set => SetProperty(ref _RefIndicatorStatusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolIndicatorStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            IndicatorStatus = model.IndicatorStatus;
            IndicatorStatusSubgroup = model.IndicatorStatusSubgroup;
            K12SchoolId = model.K12SchoolId;
            RefIndicatorStateDefinedStatusId = model.RefIndicatorStateDefinedStatusId;
            RefIndicatorStatusCustomTypeId = model.RefIndicatorStatusCustomTypeId;
            RefIndicatorStatusSubgroupTypeId = model.RefIndicatorStatusSubgroupTypeId;
            RefIndicatorStatusTypeId = model.RefIndicatorStatusTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
