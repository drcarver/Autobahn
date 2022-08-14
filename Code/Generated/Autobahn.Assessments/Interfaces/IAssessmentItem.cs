//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String BodyText { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.Decimal? Difficulty { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String DistractorAnalysis { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.Boolean? LinkingItemIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String MaximumScore { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String MinimumScore { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.Boolean? ReleaseStatus { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RubricId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String Stem { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String Stimulus { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        System.String TextComplexityValue { get; set; }

    }
}
