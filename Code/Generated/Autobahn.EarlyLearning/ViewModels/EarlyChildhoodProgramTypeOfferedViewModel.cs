//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodProgramTypeOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOfferedViewModel
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedViewModel : ViewModelBase, Interfaces.IEarlyChildhoodProgramTypeOfferedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodProgramTypeOffered";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefEarlyChildhoodProgramEnrollmentTypeId property
        private Guid _RefEarlyChildhoodProgramEnrollmentTypeId;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the RefCommunityBasedTypeId property
        private Guid? _RefCommunityBasedTypeId;

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
        /// The title of the EarlyChildhoodProgramTypeOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramEnrollmentTypeId"/> model
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get => _RefEarlyChildhoodProgramEnrollmentTypeId; set => SetProperty(ref _RefEarlyChildhoodProgramEnrollmentTypeId, value); }

        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunityBasedTypeId"/> model
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get => _RefCommunityBasedTypeId; set => SetProperty(ref _RefCommunityBasedTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodProgramTypeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefEarlyChildhoodProgramEnrollmentTypeId = model.RefEarlyChildhoodProgramEnrollmentTypeId;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            RefCommunityBasedTypeId = model.RefCommunityBasedTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
