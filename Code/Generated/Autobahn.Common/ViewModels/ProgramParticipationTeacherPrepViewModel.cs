//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTeacherPrepViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTeacherPrepViewModel
     /// </summary>
    public partial class ProgramParticipationTeacherPrepViewModel : ViewModelBase, Interfaces.IProgramParticipationTeacherPrepViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTeacherPrep";

        // member variable for the RefTeacherPrepEnrollmentStatusId property
        private Guid? _RefTeacherPrepEnrollmentStatusId;

        // member variable for the RefTeacherPrepCompleterStatusId property
        private Guid? _RefTeacherPrepCompleterStatusId;

        // member variable for the RefSupervisedClinicalExperienceId property
        private Guid? _RefSupervisedClinicalExperienceId;

        // member variable for the ClinicalExperienceClockHours property
        private System.Int32? _ClinicalExperienceClockHours;

        // member variable for the RefTeachingCredentialBasisId property
        private Guid? _RefTeachingCredentialBasisId;

        // member variable for the RefTeachingCredentialTypeId property
        private Guid? _RefTeachingCredentialTypeId;

        // member variable for the RefCriticalTeacherShortageCandidateId property
        private Guid? _RefCriticalTeacherShortageCandidateId;

        // member variable for the RefAltRouteToCertificationOrLicensureId property
        private Guid? _RefAltRouteToCertificationOrLicensureId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the SchoolAgeEducationPSCredits property
        private System.Decimal? _SchoolAgeEducationPSCredits;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTeacherPrepViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get => _RefTeacherPrepEnrollmentStatusId; set => SetProperty(ref _RefTeacherPrepEnrollmentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatusId"/> model
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get => _RefTeacherPrepCompleterStatusId; set => SetProperty(ref _RefTeacherPrepCompleterStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperienceId"/> model
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get => _RefSupervisedClinicalExperienceId; set => SetProperty(ref _RefSupervisedClinicalExperienceId, value); }

        public System.Int32? ClinicalExperienceClockHours { get => _ClinicalExperienceClockHours; set => SetProperty(ref _ClinicalExperienceClockHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasisId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialTypeId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidateId"/> model
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get => _RefCriticalTeacherShortageCandidateId; set => SetProperty(ref _RefCriticalTeacherShortageCandidateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensureId"/> model
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get => _RefAltRouteToCertificationOrLicensureId; set => SetProperty(ref _RefAltRouteToCertificationOrLicensureId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTeacherPrep model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTeacherPrepEnrollmentStatusId = model.RefTeacherPrepEnrollmentStatusId;
            RefTeacherPrepCompleterStatusId = model.RefTeacherPrepCompleterStatusId;
            RefSupervisedClinicalExperienceId = model.RefSupervisedClinicalExperienceId;
            ClinicalExperienceClockHours = model.ClinicalExperienceClockHours;
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId;
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId;
            RefCriticalTeacherShortageCandidateId = model.RefCriticalTeacherShortageCandidateId;
            RefAltRouteToCertificationOrLicensureId = model.RefAltRouteToCertificationOrLicensureId;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
