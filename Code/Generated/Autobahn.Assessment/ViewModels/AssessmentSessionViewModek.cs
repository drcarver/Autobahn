//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSessionViewModel
     /// </summary>
    public partial class AssessmentSessionViewModel : BindableBase, IAssessmentSession
    {
#region "Backing Fields"
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

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

        // member variable for the Location property
        private System.String _Location;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        public System.DateTime? ScheduledStartDateTime { get => _ScheduledStartDateTime; set => SetProperty(ref _ScheduledStartDateTime, value); }

        public System.DateTime? ScheduledEndDateTime { get => _ScheduledEndDateTime; set => SetProperty(ref _ScheduledEndDateTime, value); }

        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        public System.TimeSpan? AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get; set; }

        public System.String SecurityIssue  { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        public System.String SpecialEventDescription  { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        public System.String Location  { get => _Location; set => SetProperty(ref _Location, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_OrganizationId"/> model
        /// </summary>
        public Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_OrganizationId"/> model
        /// </summary>
        public Guid? School_OrganizationId { get; set; }

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
        public void Load(IAssessmentSession model)
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
