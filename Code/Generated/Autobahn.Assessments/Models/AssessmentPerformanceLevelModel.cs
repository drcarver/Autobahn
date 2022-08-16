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
        /// 
        /// </summary>
        public  DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LowerCutScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ScoreMetric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  UpperCutScore { get; set; }

    }
}
