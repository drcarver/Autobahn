//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResult.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentResult Interface
     /// </summary>
    public partial interface IAssessmentResult : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentResultScoreStandardError { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DateUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DescriptiveFeedbackSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DiagnosticStatement { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DiagnosticStatementSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstructionalRecommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfResponses { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PreliminaryIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentPretestOutcomeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentResultScoreTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefOutcomeTimePointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ScoreValue { get; set; }

    }
}
