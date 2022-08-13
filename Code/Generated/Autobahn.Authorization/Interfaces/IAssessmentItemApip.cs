//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemApip.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentItemApip Interface
     /// </summary>
    public partial interface IAssessmentItemApip : IAutobahnBase
    {
        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String ItemBodyXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String ModalFeedbackXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String OutcomeDeclarationXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String ResponseDeclarationXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String ResponseProcessingTemplateUrl { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String ResponseProcessingXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String TemplateDeclarationXml { get; set; }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        System.String TemplateProcessingXml { get; set; }

    }
}
