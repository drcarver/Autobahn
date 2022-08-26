//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResult.cs
//* Name:       Assessment Result Score Value
//* Definition: A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
     /// </summary>
    public partial interface IAssessmentResult : IAutobahnBase
    {
    }
}
