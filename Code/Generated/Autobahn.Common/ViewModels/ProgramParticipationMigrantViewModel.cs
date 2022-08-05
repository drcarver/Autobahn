//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationMigrantViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationMigrantViewModel
     /// </summary>
    public partial class ProgramParticipationMigrantViewModel : ViewModelBase, Interfaces.IProgramParticipationMigrant
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationMigrant";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefMepEnrollmentTypeId property
        private Guid? _RefMepEnrollmentTypeId;

        // member variable for the RefMepProjectBasedId property
        private Guid? _RefMepProjectBasedId;

        // member variable for the RefMepServiceTypeId property
        private Guid? _RefMepServiceTypeId;

        // member variable for the MepEligibilityExpirationDate property
        private System.DateTime? _MepEligibilityExpirationDate;

        // member variable for the ContinuationOfServicesStatus property
        private System.Boolean? _ContinuationOfServicesStatus;

        // member variable for the RefContinuationOfServicesReasonId property
        private Guid? _RefContinuationOfServicesReasonId;

        // member variable for the BirthdateVerification property
        private System.String _BirthdateVerification;

        // member variable for the ImmunizationRecordFlag property
        private System.Boolean? _ImmunizationRecordFlag;

        // member variable for the MigrantStudentQualifyingArrivalDate property
        private System.DateTime? _MigrantStudentQualifyingArrivalDate;

        // member variable for the LastQualifyingMoveDate property
        private System.DateTime? _LastQualifyingMoveDate;

        // member variable for the QualifyingMoveFromCity property
        private System.String _QualifyingMoveFromCity;

        // member variable for the RefQualifyingMoveFromStateId property
        private Guid? _RefQualifyingMoveFromStateId;

        // member variable for the RefQualifyingMoveFromCountryId property
        private Guid? _RefQualifyingMoveFromCountryId;

        // member variable for the DesignatedGraduationSchoolId property
        private Guid? _DesignatedGraduationSchoolId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the PrioritizedForServices property
        private System.Boolean? _PrioritizedForServices;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationMigrantViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentTypeId"/> model
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get => _RefMepEnrollmentTypeId; set => SetProperty(ref _RefMepEnrollmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBasedId"/> model
        /// </summary>
        public Guid? RefMepProjectBasedId { get => _RefMepProjectBasedId; set => SetProperty(ref _RefMepProjectBasedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceTypeId"/> model
        /// </summary>
        public Guid? RefMepServiceTypeId { get => _RefMepServiceTypeId; set => SetProperty(ref _RefMepServiceTypeId, value); }

        public System.DateTime? MepEligibilityExpirationDate { get => _MepEligibilityExpirationDate; set => SetProperty(ref _MepEligibilityExpirationDate, value); }

        public System.Boolean? ContinuationOfServicesStatus { get => _ContinuationOfServicesStatus; set => SetProperty(ref _ContinuationOfServicesStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReasonId"/> model
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get => _RefContinuationOfServicesReasonId; set => SetProperty(ref _RefContinuationOfServicesReasonId, value); }

        public System.String BirthdateVerification  { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        public System.Boolean? ImmunizationRecordFlag { get => _ImmunizationRecordFlag; set => SetProperty(ref _ImmunizationRecordFlag, value); }

        public System.DateTime? MigrantStudentQualifyingArrivalDate { get => _MigrantStudentQualifyingArrivalDate; set => SetProperty(ref _MigrantStudentQualifyingArrivalDate, value); }

        public System.DateTime? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        public System.String QualifyingMoveFromCity  { get => _QualifyingMoveFromCity; set => SetProperty(ref _QualifyingMoveFromCity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromStateId"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get => _RefQualifyingMoveFromStateId; set => SetProperty(ref _RefQualifyingMoveFromStateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountryId"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get => _RefQualifyingMoveFromCountryId; set => SetProperty(ref _RefQualifyingMoveFromCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchoolId"/> model
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get => _DesignatedGraduationSchoolId; set => SetProperty(ref _DesignatedGraduationSchoolId, value); }

        public System.Boolean? PrioritizedForServices { get => _PrioritizedForServices; set => SetProperty(ref _PrioritizedForServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId;
            RefMepProjectBasedId = model.RefMepProjectBasedId;
            RefMepServiceTypeId = model.RefMepServiceTypeId;
            MepEligibilityExpirationDate = model.MepEligibilityExpirationDate;
            ContinuationOfServicesStatus = model.ContinuationOfServicesStatus;
            RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId;
            BirthdateVerification = model.BirthdateVerification;
            ImmunizationRecordFlag = model.ImmunizationRecordFlag;
            MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate;
            LastQualifyingMoveDate = model.LastQualifyingMoveDate;
            QualifyingMoveFromCity = model.QualifyingMoveFromCity;
            RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId;
            RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId;
            DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId;
            PrioritizedForServices = model.PrioritizedForServices;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
