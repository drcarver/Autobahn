//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSessionStaffRoleViewModel
     /// </summary>
    public partial class AssessmentSessionStaffRoleViewModel : ViewModelBase, Interfaces.IAssessmentSessionStaffRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSessionStaffRole";

        // member variable for the AssessmentParticipantSessionId property
        private Guid? _AssessmentParticipantSessionId;

        // member variable for the AssessmentSessionId property
        private Guid? _AssessmentSessionId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefAssessmentSessionStaffRoleTypeId property
        private Guid? _RefAssessmentSessionStaffRoleTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSessionStaffRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get => _AssessmentParticipantSessionId; set => SetProperty(ref _AssessmentParticipantSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get => _AssessmentSessionId; set => SetProperty(ref _AssessmentSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get => _RefAssessmentSessionStaffRoleTypeId; set => SetProperty(ref _RefAssessmentSessionStaffRoleTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSessionStaffRole model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            AssessmentSessionId = model.AssessmentSessionId;
            PersonId = model.PersonId;
            RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
