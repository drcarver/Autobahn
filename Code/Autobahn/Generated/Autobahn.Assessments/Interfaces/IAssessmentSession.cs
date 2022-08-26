//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSession.cs
//* Name:       Assessment Session Special Circumstance Type
//* Definition: An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
     /// </summary>
    public partial interface IAssessmentSession : IAutobahnBase
    {
    }
}
