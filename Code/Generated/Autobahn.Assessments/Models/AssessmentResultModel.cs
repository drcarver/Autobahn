//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResult Model
     /// </summary>
    public partial class AssessmentResultModel : AutobahnBase, Interfaces.IAssessmentResult
    {
        /// <summary>
        /// 
        /// </summary>
        public  AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentResultScoreStandardError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DateUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DescriptiveFeedbackSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DiagnosticStatement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DiagnosticStatementSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstructionalRecommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfResponses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PreliminaryIndicator { get; set; }

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
        public  RefAssessmentPretestOutcomeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentResultScoreTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefOutcomeTimePointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ScoreValue { get; set; }

    }
}
