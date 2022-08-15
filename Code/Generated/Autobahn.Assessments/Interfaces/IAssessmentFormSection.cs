//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// The globally unique identifier of an Assessment using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String GUID { get; set; }

    }
}
