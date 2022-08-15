//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResult.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentResult Interface
     /// </summary>
    public partial interface IAssessmentResult : IAutobahnBase
    {
        /// <summary>
        /// The score given to a person's response to an assessment item.
        /// </summary>
        System.String ScoreValue { get; set; }

    }
}
