//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSession Model
     /// </summary>
    public partial class ProfessionalDevelopmentSessionModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSession
    {
        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.Int32? Capacity { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EndTime { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EvaluationMethod { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EvaluationScore { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String FundingSource { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String LocationName { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String SessionIdentifier { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String SponsoringAgencyName { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String StartTime { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String TrainingAndTechnicalAssistanceLevel { get; set; }

    }
}
