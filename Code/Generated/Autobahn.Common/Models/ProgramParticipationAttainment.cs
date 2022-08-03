//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationAttainment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationAttainment
     /// </summary>
    public partial class ProgramParticipationAttainment : IProgramParticipationAttainment
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
        /// Defines the ProgramParticipationAttainment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

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
