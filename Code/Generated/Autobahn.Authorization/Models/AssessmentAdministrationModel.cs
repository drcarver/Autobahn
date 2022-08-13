//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAdministration
    {
        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.String AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public Guid? AssessmentId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.DateTime? FinishDate { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.TimeSpan? FinishTime { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public Guid? RefAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

    }
}
