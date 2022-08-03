//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAdministration.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAdministration
     /// </summary>
    public partial interface IAssessmentAdministration
    {
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
        /// Defines the AssessmentAdministration.AssessmentSecureIndicator nullable property
        /// </summary>
        System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.AssessmentAdministrationPeriodDescription non nullable property
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
