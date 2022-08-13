//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSession Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentSession : IAutobahnBase
    {
        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.Int32? Capacity { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String EndTime { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String EvaluationMethod { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String EvaluationScore { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String FundingSource { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String LocationName { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid? RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid? RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String SessionIdentifier { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String SponsoringAgencyName { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String StartTime { get; set; }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        System.String TrainingAndTechnicalAssistanceLevel { get; set; }

    }
}
