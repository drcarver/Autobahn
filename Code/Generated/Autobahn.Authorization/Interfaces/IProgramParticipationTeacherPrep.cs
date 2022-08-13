//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTeacherPrep.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTeacherPrep Interface
     /// </summary>
    public partial interface IProgramParticipationTeacherPrep : IAutobahnBase
    {
        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

    }
}
