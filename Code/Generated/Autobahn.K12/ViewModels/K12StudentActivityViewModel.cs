//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentActivityViewModel
     /// </summary>
    public partial class K12StudentActivityViewModel : ViewModelBase, Interfaces.IK12StudentActivityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentActivity";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ActivityTimeInvolved property
        private System.Decimal? _ActivityTimeInvolved;

        // member variable for the RefActivityTimeMeasurementTypeId property
        private Guid? _RefActivityTimeMeasurementTypeId;

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
        /// The title of the K12StudentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? ActivityTimeInvolved { get => _ActivityTimeInvolved; set => SetProperty(ref _ActivityTimeInvolved, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementTypeId"/> model
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get => _RefActivityTimeMeasurementTypeId; set => SetProperty(ref _RefActivityTimeMeasurementTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ActivityTimeInvolved = model.ActivityTimeInvolved;
            RefActivityTimeMeasurementTypeId = model.RefActivityTimeMeasurementTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
