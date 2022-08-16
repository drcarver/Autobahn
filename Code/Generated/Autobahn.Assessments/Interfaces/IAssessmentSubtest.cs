//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtest.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest Interface
     /// </summary>
    public partial interface IAssessmentSubtest : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Abbreviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ContainerOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OptimalValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublishedDate { get; set; }

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
        Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentSubtestIdentifierTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefContentStandardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
