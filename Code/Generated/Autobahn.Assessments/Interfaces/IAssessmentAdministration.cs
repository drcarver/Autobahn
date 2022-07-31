//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessmentAdministration.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAdministration
     /// </summary>
    public partial Interface IAssessmentAdministration
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid? AssessmentId { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartTime nullable property
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishDate nullable property
        /// </summary>
        System.DateTime? FinishDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishTime nullable property
        /// </summary>
        System.TimeSpan? FinishTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
        /// </summary>
        Guid? RefAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
    System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// The period or window in which an assessment is supposed to be administered.
        /// </summary>
    System.String AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
