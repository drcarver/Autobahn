//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationMigrant.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationMigrant
     /// </summary>
    public partial interface IProgramParticipationMigrant : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentType"/> model
        /// </summary>
        Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBased"/> model
        /// </summary>
        Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceType"/> model
        /// </summary>
        Guid? RefMepServiceTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.MepEligibilityExpirationDate nullable property
        /// </summary>
        System.DateTime? MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.ContinuationOfServicesStatus nullable property
        /// </summary>
        System.Boolean? ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        Guid? RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.BirthdateVerification non nullable property
        /// </summary>
        System.String BirthdateVerification { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.ImmunizationRecordFlag nullable property
        /// </summary>
        System.Boolean? ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.MigrantStudentQualifyingArrivalDate nullable property
        /// </summary>
        System.DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.LastQualifyingMoveDate nullable property
        /// </summary>
        System.DateTime? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.QualifyingMoveFromCity non nullable property
        /// </summary>
        System.String QualifyingMoveFromCity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromState"/> model
        /// </summary>
        Guid? RefQualifyingMoveFromStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountry"/> model
        /// </summary>
        Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchool"/> model
        /// </summary>
        Guid? DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.PrioritizedForServices nullable property
        /// </summary>
        System.Boolean? PrioritizedForServices { get; set; }

    }
}
