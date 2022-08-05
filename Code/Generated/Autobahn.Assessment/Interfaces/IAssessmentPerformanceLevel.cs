//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPerformanceLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPerformanceLevel
     /// </summary>
    public partial interface IAssessmentPerformanceLevel : IAutobahnBase
    {
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

    }
}
