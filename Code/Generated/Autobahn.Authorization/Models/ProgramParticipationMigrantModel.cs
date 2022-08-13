//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationMigrantModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProgramParticipationMigrant Model
     /// </summary>
    public partial class ProgramParticipationMigrantModel : AutobahnBase, Interfaces.IProgramParticipationMigrant
    {
        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.String BirthdateVerification { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? PrioritizedForServices { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.String QualifyingMoveFromCity { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefMepServiceTypeId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get; set; }

    }
}
