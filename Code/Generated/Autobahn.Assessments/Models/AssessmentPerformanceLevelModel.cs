//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPerformanceLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPerformanceLevel Model
     /// </summary>
    public partial class AssessmentPerformanceLevelModel : AutobahnBase, Interfaces.IAssessmentPerformanceLevel
    {
        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public Guid? AssessmentSubtestId { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String Label { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String LowerCutScore { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String ScoreMetric { get; set; }

        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        public System.String UpperCutScore { get; set; }

    }
}
