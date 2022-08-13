//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentResult.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentResult Interface
     /// </summary>
    public partial interface IAssessmentResult : IAutobahnBase
    {
        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.Decimal? AssessmentResultScoreStandardError { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.DateTime? DateUpdated { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String DescriptiveFeedbackSource { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String DiagnosticStatement { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String DiagnosticStatementSource { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.Boolean? IncludedInAypCalculation { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String InstructionalRecommendation { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.Int32? NumberOfResponses { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.Boolean? PreliminaryIndicator { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefAssessmentPretestOutcomeId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefAssessmentResultDataTypeId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefAssessmentResultScoreTypeId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefELOutcomeMeasurementLevelId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefOutcomeTimePointId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
        /// </summary>
        System.String ScoreValue { get; set; }

    }
}
