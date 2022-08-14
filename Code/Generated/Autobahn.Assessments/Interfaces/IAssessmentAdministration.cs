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
        System.String AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        Guid? AssessmentId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.DateTime? FinishDate { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.TimeSpan? FinishTime { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        Guid? RefAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

    }
}
