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
        public System.String ScoreMetric { get; set; }

    }
}
