//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemApip Model
     /// </summary>
    public partial class AssessmentItemApipModel : AutobahnBase, Interfaces.IAssessmentItemApip
    {
        /// <summary>
        /// 
        /// </summary>
        public  AdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ItemBodyXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ModalFeedbackXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OutcomeDeclarationXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ResponseDeclarationXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ResponseProcessingTemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ResponseProcessingXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TemplateDeclarationXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TemplateProcessingXml { get; set; }

    }
}
