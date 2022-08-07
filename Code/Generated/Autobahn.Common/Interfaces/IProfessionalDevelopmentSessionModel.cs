//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentSessionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSessionModel Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentSessionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.SessionIdentifier non nullable property
        /// </summary>
        System.String SessionIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethod"/> model
        /// </summary>
        Guid? RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.Capacity nullable property
        /// </summary>
        System.Int32? Capacity { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.StartTime non nullable property
        /// </summary>
        System.String StartTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EndTime non nullable property
        /// </summary>
        System.String EndTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.LocationName non nullable property
        /// </summary>
        System.String LocationName { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EvaluationMethod non nullable property
        /// </summary>
        System.String EvaluationMethod { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EvaluationScore non nullable property
        /// </summary>
        System.String EvaluationScore { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.ExpirationDate nullable property
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryMode"/> model
        /// </summary>
        Guid? RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.SponsoringAgencyName non nullable property
        /// </summary>
        System.String SponsoringAgencyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.FundingSource non nullable property
        /// </summary>
        System.String FundingSource { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.TrainingAndTechnicalAssistanceLevel non nullable property
        /// </summary>
        System.String TrainingAndTechnicalAssistanceLevel { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeArea"/> model
        /// </summary>
        Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

    }
}
