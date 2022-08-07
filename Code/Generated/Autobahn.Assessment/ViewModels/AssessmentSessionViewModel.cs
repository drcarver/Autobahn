//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSessionViewModel
     /// </summary>
    public partial class AssessmentSessionViewModel : ViewModelBase, Interfaces.IAssessmentSessionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSession";

        // member variable for the AssessmentAdministrationId property
        private Guid? _AssessmentAdministrationId;

        // member variable for the ScheduledStartDateTime property
        private System.DateTime? _ScheduledStartDateTime;

        // member variable for the ScheduledEndDateTime property
        private System.DateTime? _ScheduledEndDateTime;

        // member variable for the ActualStartDateTime property
        private System.DateTime? _ActualStartDateTime;

        // member variable for the ActualEndDateTime property
        private System.DateTime? _ActualEndDateTime;

        // member variable for the AllottedTime property
        private System.TimeSpan? _AllottedTime;

        // member variable for the RefAssessmentSessionTypeId property
        private Guid? _RefAssessmentSessionTypeId;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private Guid? _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

        // member variable for the Location property
        private System.String _Location;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the Lea_OrganizationId property
        private Guid? _Lea_OrganizationId;

        // member variable for the School_OrganizationId property
        private Guid? _School_OrganizationId;

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
        /// The title of the AssessmentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        public System.DateTime? ScheduledStartDateTime { get => _ScheduledStartDateTime; set => SetProperty(ref _ScheduledStartDateTime, value); }

        public System.DateTime? ScheduledEndDateTime { get => _ScheduledEndDateTime; set => SetProperty(ref _ScheduledEndDateTime, value); }

        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        public System.TimeSpan? AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get => _RefAssessmentSessionTypeId; set => SetProperty(ref _RefAssessmentSessionTypeId, value); }

        public System.String SecurityIssue  { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        public System.String SpecialEventDescription  { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        public System.String Location  { get => _Location; set => SetProperty(ref _Location, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_OrganizationId"/> model
        /// </summary>
        public Guid? Lea_OrganizationId { get => _Lea_OrganizationId; set => SetProperty(ref _Lea_OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_OrganizationId"/> model
        /// </summary>
        public Guid? School_OrganizationId { get => _School_OrganizationId; set => SetProperty(ref _School_OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            ScheduledStartDateTime = model.ScheduledStartDateTime;
            ScheduledEndDateTime = model.ScheduledEndDateTime;
            ActualStartDateTime = model.ActualStartDateTime;
            ActualEndDateTime = model.ActualEndDateTime;
            AllottedTime = model.AllottedTime;
            RefAssessmentSessionTypeId = model.RefAssessmentSessionTypeId;
            SecurityIssue = model.SecurityIssue;
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId;
            SpecialEventDescription = model.SpecialEventDescription;
            Location = model.Location;
            OrganizationId = model.OrganizationId;
            Lea_OrganizationId = model.Lea_OrganizationId;
            School_OrganizationId = model.School_OrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
