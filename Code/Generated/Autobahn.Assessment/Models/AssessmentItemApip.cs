//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApip.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemApip
     /// </summary>
    public partial class AssessmentItemApip : AutobahnBase, Interfaces.IAssessmentItemApip
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.AdaptiveIndicator nullable property
        /// </summary>
        public System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseProcessingTemplateUrl non nullable property
        /// </summary>
        public System.String ResponseProcessingTemplateUrl { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseProcessingXml non nullable property
        /// </summary>
        public System.String ResponseProcessingXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ResponseDeclarationXml non nullable property
        /// </summary>
        public System.String ResponseDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.OutcomeDeclarationXml non nullable property
        /// </summary>
        public System.String OutcomeDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.TemplateDeclarationXml non nullable property
        /// </summary>
        public System.String TemplateDeclarationXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.TemplateProcessingXml non nullable property
        /// </summary>
        public System.String TemplateProcessingXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ModalFeedbackXml non nullable property
        /// </summary>
        public System.String ModalFeedbackXml { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApip.ItemBodyXml non nullable property
        /// </summary>
        public System.String ItemBodyXml { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
