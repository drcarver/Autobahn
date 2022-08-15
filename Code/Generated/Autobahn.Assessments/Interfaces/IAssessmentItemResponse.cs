//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemResponse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponse Interface
     /// </summary>
    public partial interface IAssessmentItemResponse : IAutobahnBase
    {
        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.TimeSpan? Duration { get; set; }

    }
}
