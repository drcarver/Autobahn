//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTeacherPrepViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTeacherPrepViewModel
     /// </summary>
    public partial class ProgramParticipationTeacherPrepViewModel : ViewModelBase, Interfaces.IProgramParticipationTeacherPrep
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTeacherPrep";

        // member variable for the ClinicalExperienceClockHours property
        private System.Int32? _ClinicalExperienceClockHours;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefAltRouteToCertificationOrLicensureId property
        private Guid? _RefAltRouteToCertificationOrLicensureId;

        // member variable for the RefCriticalTeacherShortageCandidateId property
        private Guid? _RefCriticalTeacherShortageCandidateId;

        // member variable for the RefSupervisedClinicalExperienceId property
        private Guid? _RefSupervisedClinicalExperienceId;

        // member variable for the RefTeacherPrepCompleterStatusId property
        private Guid? _RefTeacherPrepCompleterStatusId;

        // member variable for the RefTeacherPrepEnrollmentStatusId property
        private Guid? _RefTeacherPrepEnrollmentStatusId;

        // member variable for the RefTeachingCredentialBasisId property
        private Guid? _RefTeachingCredentialBasisId;

        // member variable for the RefTeachingCredentialTypeId property
        private Guid? _RefTeachingCredentialTypeId;

        // member variable for the SchoolAgeEducationPSCredits property
        private System.Decimal? _SchoolAgeEducationPSCredits;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTeacherPrepViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public System.Int32? ClinicalExperienceClockHours { get => _ClinicalExperienceClockHours; set => SetProperty(ref _ClinicalExperienceClockHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get => _RefAltRouteToCertificationOrLicensureId; set => SetProperty(ref _RefAltRouteToCertificationOrLicensureId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get => _RefCriticalTeacherShortageCandidateId; set => SetProperty(ref _RefCriticalTeacherShortageCandidateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get => _RefSupervisedClinicalExperienceId; set => SetProperty(ref _RefSupervisedClinicalExperienceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get => _RefTeacherPrepCompleterStatusId; set => SetProperty(ref _RefTeacherPrepCompleterStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get => _RefTeacherPrepEnrollmentStatusId; set => SetProperty(ref _RefTeacherPrepEnrollmentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTeacherPrep model)
        {
            IsBusy = true;
            Id = model.Id;
            ClinicalExperienceClockHours = model.ClinicalExperienceClockHours;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefAltRouteToCertificationOrLicensureId = model.RefAltRouteToCertificationOrLicensureId;
            RefCriticalTeacherShortageCandidateId = model.RefCriticalTeacherShortageCandidateId;
            RefSupervisedClinicalExperienceId = model.RefSupervisedClinicalExperienceId;
            RefTeacherPrepCompleterStatusId = model.RefTeacherPrepCompleterStatusId;
            RefTeacherPrepEnrollmentStatusId = model.RefTeacherPrepEnrollmentStatusId;
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId;
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId;
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
