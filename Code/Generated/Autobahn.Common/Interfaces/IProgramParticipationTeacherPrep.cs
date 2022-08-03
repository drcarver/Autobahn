//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationTeacherPrep.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTeacherPrep
     /// </summary>
    public partial interface IProgramParticipationTeacherPrep
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.ClinicalExperienceClockHours nullable property
        /// </summary>
        System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTeacherPrep.SchoolAgeEducationPSCredits nullable property
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
