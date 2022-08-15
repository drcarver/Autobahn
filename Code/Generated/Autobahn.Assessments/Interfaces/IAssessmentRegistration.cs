//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentRegistration.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration Interface
     /// </summary>
    public partial interface IAssessmentRegistration : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether a student participated in an assessment.
        /// </summary>
        Guid? RefAssessmentParticipationIndicatorId { get; set; }

    }
}
