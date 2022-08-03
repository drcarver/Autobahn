//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTeacherPrep.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationTeacherPrep
     /// </summary>
    public partial class ProgramParticipationTeacherPrep : IProgramParticipationTeacherPrep
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.ClinicalExperienceClockHours nullable property
        /// </summary>
        public System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.SchoolAgeEducationPSCredits nullable property
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}