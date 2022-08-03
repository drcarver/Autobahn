//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSession.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSession
     /// </summary>
    public partial class ProfessionalDevelopmentSession : IProfessionalDevelopmentSession
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.SessionIdentifier non nullable property
        /// </summary>
        public System.String SessionIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethod"/> model
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.Capacity nullable property
        /// </summary>
        public System.Int32? Capacity { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.StartTime non nullable property
        /// </summary>
        public System.String StartTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EndTime non nullable property
        /// </summary>
        public System.String EndTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.LocationName non nullable property
        /// </summary>
        public System.String LocationName { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EvaluationMethod non nullable property
        /// </summary>
        public System.String EvaluationMethod { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.EvaluationScore non nullable property
        /// </summary>
        public System.String EvaluationScore { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.ExpirationDate nullable property
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        public Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryMode"/> model
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.SponsoringAgencyName non nullable property
        /// </summary>
        public System.String SponsoringAgencyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.FundingSource non nullable property
        /// </summary>
        public System.String FundingSource { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.TrainingAndTechnicalAssistanceLevel non nullable property
        /// </summary>
        public System.String TrainingAndTechnicalAssistanceLevel { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeArea"/> model
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSession.RecordEndDateTime nullable property
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
