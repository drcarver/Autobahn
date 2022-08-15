//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAdministration.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAdministration Interface
     /// </summary>
    public partial interface IAssessmentAdministration : IAutobahnBase
    {
        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.Boolean? AssessmentSecureIndicator { get; set; }

    }
}
