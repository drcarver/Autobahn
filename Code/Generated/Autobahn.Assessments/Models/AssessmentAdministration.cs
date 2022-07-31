//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   AssessmentAdministration.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministration
     /// </summary>
    public partial class AssessmentAdministration : IAssessmentAdministration
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid? AssessmentId { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartTime nullable property
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishDate nullable property
        /// </summary>
        public System.DateTime? FinishDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishTime nullable property
        /// </summary>
        public System.TimeSpan? FinishTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
        /// </summary>
        public Guid? RefAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
    public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// The period or window in which an assessment is supposed to be administered.
        /// </summary>
    public System.String AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
