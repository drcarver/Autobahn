//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTeacherPrepViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
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
        private  _ClinicalExperienceClockHours;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAltRouteToCertificationOrLicensureId property
        private  _RefAltRouteToCertificationOrLicensureId;

        // member variable for the RefCriticalTeacherShortageCandidateId property
        private  _RefCriticalTeacherShortageCandidateId;

        // member variable for the RefSupervisedClinicalExperienceId property
        private  _RefSupervisedClinicalExperienceId;

        // member variable for the RefTeacherPrepCompleterStatusId property
        private  _RefTeacherPrepCompleterStatusId;

        // member variable for the RefTeacherPrepEnrollmentStatusId property
        private  _RefTeacherPrepEnrollmentStatusId;

        // member variable for the RefTeachingCredentialBasisId property
        private Guid? _RefTeachingCredentialBasisId;

        // member variable for the RefTeachingCredentialTypeId property
        private  _RefTeachingCredentialTypeId;

        // member variable for the SchoolAgeEducationPSCredits property
        private  _SchoolAgeEducationPSCredits;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ClinicalExperienceClockHours { get => _ClinicalExperienceClockHours; set => SetProperty(ref _ClinicalExperienceClockHours, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        public  RefAltRouteToCertificationOrLicensureId { get => _RefAltRouteToCertificationOrLicensureId; set => SetProperty(ref _RefAltRouteToCertificationOrLicensureId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        public  RefCriticalTeacherShortageCandidateId { get => _RefCriticalTeacherShortageCandidateId; set => SetProperty(ref _RefCriticalTeacherShortageCandidateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        public  RefSupervisedClinicalExperienceId { get => _RefSupervisedClinicalExperienceId; set => SetProperty(ref _RefSupervisedClinicalExperienceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        public  RefTeacherPrepCompleterStatusId { get => _RefTeacherPrepCompleterStatusId; set => SetProperty(ref _RefTeacherPrepCompleterStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        public  RefTeacherPrepEnrollmentStatusId { get => _RefTeacherPrepEnrollmentStatusId; set => SetProperty(ref _RefTeacherPrepEnrollmentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public  RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// </summary>
        public  SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTeacherPrep model)
        {
            IsBusy = true;
            Id = model.Id;
            ClinicalExperienceClockHours = model.ClinicalExperienceClockHours; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAltRouteToCertificationOrLicensureId = model.RefAltRouteToCertificationOrLicensureId; // 
            RefCriticalTeacherShortageCandidateId = model.RefCriticalTeacherShortageCandidateId; // 
            RefSupervisedClinicalExperienceId = model.RefSupervisedClinicalExperienceId; // 
            RefTeacherPrepCompleterStatusId = model.RefTeacherPrepCompleterStatusId; // 
            RefTeacherPrepEnrollmentStatusId = model.RefTeacherPrepEnrollmentStatusId; // 
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // 
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // 
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}