//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessmentPerformanceLevel.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPerformanceLevel
     /// </summary>
    public partial interface IAssessmentPerformanceLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid? AssessmentSubtestId { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.ScoreMetric non nullable property
        /// </summary>
        System.String ScoreMetric { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.Label non nullable property
        /// </summary>
        System.String Label { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.LowerCutScore non nullable property
        /// </summary>
        System.String LowerCutScore { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.UpperCutScore non nullable property
        /// </summary>
        System.String UpperCutScore { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.DescriptiveFeedback non nullable property
        /// </summary>
        System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.RecordEndDateTime nullable property
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
