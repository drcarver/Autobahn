//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationMigrant.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationMigrant Interface
     /// </summary>
    public partial interface IProgramParticipationMigrant : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.String BirthdateVerification { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.Boolean? ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.Boolean? ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.DateTime? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.DateTime? MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.Boolean? PrioritizedForServices { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.String QualifyingMoveFromCity { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefMepServiceTypeId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        Guid? RefQualifyingMoveFromStateId { get; set; }

    }
}
