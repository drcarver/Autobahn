//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramViewModel
     /// </summary>
    public partial class IndividualizedProgramViewModel : ViewModelBase, Interfaces.IIndividualizedProgramViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgram";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefIndividualizedProgramDateType property
        private System.Int32? _RefIndividualizedProgramDateType;

        // member variable for the IndividualizedProgramDate property
        private System.DateTime? _IndividualizedProgramDate;

        // member variable for the NonInclusionMinutesPerWeek property
        private System.Int32? _NonInclusionMinutesPerWeek;

        // member variable for the InclusionMinutesPerWeek property
        private System.Int32? _InclusionMinutesPerWeek;

        // member variable for the RefIndividualizedProgramTransitionTypeId property
        private Guid? _RefIndividualizedProgramTransitionTypeId;

        // member variable for the RefIndividualizedProgramTypeId property
        private Guid? _RefIndividualizedProgramTypeId;

        // member variable for the ServicePlanDate property
        private System.DateTime? _ServicePlanDate;

        // member variable for the RefIndividualizedProgramLocationId property
        private Guid? _RefIndividualizedProgramLocationId;

        // member variable for the ServicePlanMeetingParticipants property
        private System.String _ServicePlanMeetingParticipants;

        // member variable for the ServicePlanSignedBy property
        private System.String _ServicePlanSignedBy;

        // member variable for the ServicePlanSignatureDate property
        private System.DateTime? _ServicePlanSignatureDate;

        // member variable for the ServicePlanReevaluationDate property
        private System.DateTime? _ServicePlanReevaluationDate;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the ServicePlanEndDate property
        private System.DateTime? _ServicePlanEndDate;

        // member variable for the TransferOfRightsStatement property
        private System.String _TransferOfRightsStatement;

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
        /// The title of the IndividualizedProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Int32? RefIndividualizedProgramDateType { get => _RefIndividualizedProgramDateType; set => SetProperty(ref _RefIndividualizedProgramDateType, value); }

        public System.DateTime? IndividualizedProgramDate { get => _IndividualizedProgramDate; set => SetProperty(ref _IndividualizedProgramDate, value); }

        public System.Int32? NonInclusionMinutesPerWeek { get => _NonInclusionMinutesPerWeek; set => SetProperty(ref _NonInclusionMinutesPerWeek, value); }

        public System.Int32? InclusionMinutesPerWeek { get => _InclusionMinutesPerWeek; set => SetProperty(ref _InclusionMinutesPerWeek, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get => _RefIndividualizedProgramTransitionTypeId; set => SetProperty(ref _RefIndividualizedProgramTransitionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get => _RefIndividualizedProgramTypeId; set => SetProperty(ref _RefIndividualizedProgramTypeId, value); }

        public System.DateTime? ServicePlanDate { get => _ServicePlanDate; set => SetProperty(ref _ServicePlanDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocationId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get => _RefIndividualizedProgramLocationId; set => SetProperty(ref _RefIndividualizedProgramLocationId, value); }

        public System.String ServicePlanMeetingParticipants  { get => _ServicePlanMeetingParticipants; set => SetProperty(ref _ServicePlanMeetingParticipants, value); }

        public System.String ServicePlanSignedBy  { get => _ServicePlanSignedBy; set => SetProperty(ref _ServicePlanSignedBy, value); }

        public System.DateTime? ServicePlanSignatureDate { get => _ServicePlanSignatureDate; set => SetProperty(ref _ServicePlanSignatureDate, value); }

        public System.DateTime? ServicePlanReevaluationDate { get => _ServicePlanReevaluationDate; set => SetProperty(ref _ServicePlanReevaluationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceTypeId"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        public System.DateTime? ServicePlanEndDate { get => _ServicePlanEndDate; set => SetProperty(ref _ServicePlanEndDate, value); }

        public System.String TransferOfRightsStatement  { get => _TransferOfRightsStatement; set => SetProperty(ref _TransferOfRightsStatement, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType;
            IndividualizedProgramDate = model.IndividualizedProgramDate;
            NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek;
            InclusionMinutesPerWeek = model.InclusionMinutesPerWeek;
            RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId;
            RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId;
            ServicePlanDate = model.ServicePlanDate;
            RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId;
            ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants;
            ServicePlanSignedBy = model.ServicePlanSignedBy;
            ServicePlanSignatureDate = model.ServicePlanSignatureDate;
            ServicePlanReevaluationDate = model.ServicePlanReevaluationDate;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            ServicePlanEndDate = model.ServicePlanEndDate;
            TransferOfRightsStatement = model.TransferOfRightsStatement;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
