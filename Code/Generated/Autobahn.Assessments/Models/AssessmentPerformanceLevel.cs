//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   AssessmentPerformanceLevel.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPerformanceLevel
     /// </summary>
    public partial class AssessmentPerformanceLevel : IAssessmentPerformanceLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid? AssessmentSubtestId { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.ScoreMetric non nullable property
        /// </summary>
        public System.String ScoreMetric { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.Label non nullable property
        /// </summary>
        public System.String Label { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.LowerCutScore non nullable property
        /// </summary>
        public System.String LowerCutScore { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.UpperCutScore non nullable property
        /// </summary>
        public System.String UpperCutScore { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.DescriptiveFeedback non nullable property
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPerformanceLevel.RecordEndDateTime nullable property
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
