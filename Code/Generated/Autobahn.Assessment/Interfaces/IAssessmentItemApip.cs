//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemApip.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemApip
     /// </summary>
    public partial interface IAssessmentItemApip : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.AdaptiveIndicator nullable property
        /// </summary>
        System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseProcessingTemplateUrl non nullable property
        /// </summary>
        System.String ResponseProcessingTemplateUrl { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseProcessingXml non nullable property
        /// </summary>
        System.String ResponseProcessingXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseDeclarationXml non nullable property
        /// </summary>
        System.String ResponseDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.OutcomeDeclarationXml non nullable property
        /// </summary>
        System.String OutcomeDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.TemplateDeclarationXml non nullable property
        /// </summary>
        System.String TemplateDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.TemplateProcessingXml non nullable property
        /// </summary>
        System.String TemplateProcessingXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ModalFeedbackXml non nullable property
        /// </summary>
        System.String ModalFeedbackXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ItemBodyXml non nullable property
        /// </summary>
        System.String ItemBodyXml { get; set; }

    }
}
