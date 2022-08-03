//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTeacherPrepViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTeacherPrepViewModel
     /// </summary>
    public partial class ProgramParticipationTeacherPrepViewModel : BindableBase, IProgramParticipationTeacherPrep
    {
#region "Backing Fields"
        // member variable for the ClinicalExperienceClockHours property
        private System.Int32? _ClinicalExperienceClockHours;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the SchoolAgeEducationPSCredits property
        private System.Decimal? _SchoolAgeEducationPSCredits;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatusId"/> model
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperienceId"/> model
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get; set; }

        public System.Int32? ClinicalExperienceClockHours { get => _ClinicalExperienceClockHours; set => SetProperty(ref _ClinicalExperienceClockHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasisId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialTypeId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidateId"/> model
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensureId"/> model
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

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
        public void Load(IProgramParticipationTeacherPrep model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
