//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionStaffRoleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSessionStaffRoleViewModel
     /// </summary>
    public partial class AssessmentSessionStaffRoleViewModel : ViewModelBase, Interfaces.IAssessmentSessionStaffRole
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSessionStaffRole";

        // member variable for the RefAssessmentSessionStaffRoleTypeId property
        private Guid? _RefAssessmentSessionStaffRoleTypeId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the AssessmentSessionId property
        private Guid? _AssessmentSessionId;

        // member variable for the AssessmentParticipantSessionId property
        private Guid? _AssessmentParticipantSessionId;

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
        /// The title of the AssessmentSessionStaffRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get => _RefAssessmentSessionStaffRoleTypeId; set => SetProperty(ref _RefAssessmentSessionStaffRoleTypeId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSessionId"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get => _AssessmentSessionId; set => SetProperty(ref _AssessmentSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSessionId"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get => _AssessmentParticipantSessionId; set => SetProperty(ref _AssessmentParticipantSessionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSessionStaffRole model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId;
            PersonId = model.PersonId;
            AssessmentSessionId = model.AssessmentSessionId;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
