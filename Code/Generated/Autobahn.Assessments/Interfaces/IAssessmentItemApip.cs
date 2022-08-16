//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemApip.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemApip Interface
     /// </summary>
    public partial interface IAssessmentItemApip : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ItemBodyXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ModalFeedbackXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OutcomeDeclarationXml { get; set; }

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
         ResponseDeclarationXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ResponseProcessingTemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ResponseProcessingXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TemplateDeclarationXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TemplateProcessingXml { get; set; }

    }
}
