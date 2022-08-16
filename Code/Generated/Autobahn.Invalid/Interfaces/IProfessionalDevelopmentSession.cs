//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSession Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentSession : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Capacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EvaluationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EvaluationScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FundingSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LocationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDSessionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SessionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SponsoringAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TrainingAndTechnicalAssistanceLevel { get; set; }

    }
}
