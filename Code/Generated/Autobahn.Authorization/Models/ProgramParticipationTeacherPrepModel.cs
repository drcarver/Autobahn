//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTeacherPrepModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProgramParticipationTeacherPrep Model
     /// </summary>
    public partial class ProgramParticipationTeacherPrepModel : AutobahnBase, Interfaces.IProgramParticipationTeacherPrep
    {
        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get; set; }

    }
}
