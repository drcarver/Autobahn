//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemApip.cs
//* Name:       Assessment Item APIP Response Processing Template URL
//* Definition: These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
     /// </summary>
    public partial interface IAssessmentItemApip : IAutobahnBase
    {
    }
}
