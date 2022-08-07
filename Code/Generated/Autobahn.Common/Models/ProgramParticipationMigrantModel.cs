//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationMigrantModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationMigrant Model
     /// </summary>
    public partial class ProgramParticipationMigrantModel : AutobahnBase, Interfaces.IProgramParticipationMigrantModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentType"/> model
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBased"/> model
        /// </summary>
        public Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceType"/> model
        /// </summary>
        public Guid? RefMepServiceTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.MepEligibilityExpirationDate nullable property
        /// </summary>
        public System.DateTime? MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.ContinuationOfServicesStatus nullable property
        /// </summary>
        public System.Boolean? ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.BirthdateVerification non nullable property
        /// </summary>
        public System.String BirthdateVerification { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.ImmunizationRecordFlag nullable property
        /// </summary>
        public System.Boolean? ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.MigrantStudentQualifyingArrivalDate nullable property
        /// </summary>
        public System.DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.LastQualifyingMoveDate nullable property
        /// </summary>
        public System.DateTime? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.QualifyingMoveFromCity non nullable property
        /// </summary>
        public System.String QualifyingMoveFromCity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromState"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountry"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchool"/> model
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationMigrant.PrioritizedForServices nullable property
        /// </summary>
        public System.Boolean? PrioritizedForServices { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
