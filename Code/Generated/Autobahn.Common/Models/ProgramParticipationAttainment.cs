//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationAttainment.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationAttainment
     /// </summary>
    public partial class ProgramParticipationAttainment : AutobahnBase, Interfaces.IProgramParticipationAttainment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentEmployedIndicator nullable property
        /// </summary>
        public System.Boolean? AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentPSCredentialIndicator nullable property
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentPSEnrollmentIndicator nullable property
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeType"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
