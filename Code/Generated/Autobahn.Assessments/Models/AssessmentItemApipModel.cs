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
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ResponseProcessingTemplateUrl { get; set; }

    }
}
