//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentSessionViewModel
     /// </summary>
    public partial class AssessmentSessionViewModel : ViewModelBase, Interfaces.IAssessmentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSession";

        // member variable for the ActualEndDateTime property
        private System.DateTime? _ActualEndDateTime;

        // member variable for the ActualStartDateTime property
        private System.DateTime? _ActualStartDateTime;

        // member variable for the AllottedTime property
        private System.TimeSpan? _AllottedTime;

        // member variable for the AssessmentAdministrationId property
        private Guid? _AssessmentAdministrationId;

        // member variable for the Lea_OrganizationId property
        private Guid? _Lea_OrganizationId;

        // member variable for the Location property
        private System.String _Location;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private Guid? _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the RefAssessmentSessionTypeId property
        private Guid? _RefAssessmentSessionTypeId;

        // member variable for the ScheduledEndDateTime property
        private System.DateTime? _ScheduledEndDateTime;

        // member variable for the ScheduledStartDateTime property
        private System.DateTime? _ScheduledStartDateTime;

        // member variable for the School_OrganizationId property
        private Guid? _School_OrganizationId;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.TimeSpan? AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_Organization"/> model
        /// </summary>
        public Guid? Lea_OrganizationId { get => _Lea_OrganizationId; set => SetProperty(ref _Lea_OrganizationId, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String Location { get => _Location; set => SetProperty(ref _Location, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get => _RefAssessmentSessionTypeId; set => SetProperty(ref _RefAssessmentSessionTypeId, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ScheduledEndDateTime { get => _ScheduledEndDateTime; set => SetProperty(ref _ScheduledEndDateTime, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.DateTime? ScheduledStartDateTime { get => _ScheduledStartDateTime; set => SetProperty(ref _ScheduledStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_Organization"/> model
        /// </summary>
        public Guid? School_OrganizationId { get => _School_OrganizationId; set => SetProperty(ref _School_OrganizationId, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        public System.String SpecialEventDescription { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualEndDateTime = model.ActualEndDateTime;
            ActualStartDateTime = model.ActualStartDateTime;
            AllottedTime = model.AllottedTime;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            Lea_OrganizationId = model.Lea_OrganizationId;
            Location = model.Location;
            OrganizationId = model.OrganizationId;
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId;
            RefAssessmentSessionTypeId = model.RefAssessmentSessionTypeId;
            ScheduledEndDateTime = model.ScheduledEndDateTime;
            ScheduledStartDateTime = model.ScheduledStartDateTime;
            School_OrganizationId = model.School_OrganizationId;
            SecurityIssue = model.SecurityIssue;
            SpecialEventDescription = model.SpecialEventDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
