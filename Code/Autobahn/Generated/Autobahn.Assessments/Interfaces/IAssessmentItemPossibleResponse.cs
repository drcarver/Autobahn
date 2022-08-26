//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemPossibleResponse.cs
//* Name:       Assessment Item Possible Response Feedback Message
//* Definition: A message provided to the person being assessed after giving a response that matches the possible response.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// A message provided to the person being assessed after giving a response that matches the possible response.
     /// </summary>
    public partial interface IAssessmentItemPossibleResponse : IAutobahnBase
    {
    }
}
