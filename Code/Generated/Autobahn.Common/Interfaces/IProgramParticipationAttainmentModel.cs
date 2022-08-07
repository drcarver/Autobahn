//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationAttainmentModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationAttainmentModel Interface
     /// </summary>
    public partial interface IProgramParticipationAttainmentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentEmployedIndicator nullable property
        /// </summary>
        System.Boolean? AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentPSCredentialIndicator nullable property
        /// </summary>
        System.Boolean? AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAttainment.AECredentialAttainmentPSEnrollmentIndicator nullable property
        /// </summary>
        System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType"/> model
        /// </summary>
        Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeType"/> model
        /// </summary>
        Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
