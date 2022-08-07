//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemModel Interface
     /// </summary>
    public partial interface IAssessmentItemModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentItem.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentItemBankName non nullable property
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemType"/> model
        /// </summary>
        Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.BodyText non nullable property
        /// </summary>
        System.String BodyText { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Stimulus non nullable property
        /// </summary>
        System.String Stimulus { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Stem non nullable property
        /// </summary>
        System.String Stem { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AdaptiveIndicator nullable property
        /// </summary>
        System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.MaximumScore non nullable property
        /// </summary>
        System.String MaximumScore { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.MinimumScore non nullable property
        /// </summary>
        System.String MinimumScore { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.DistractorAnalysis non nullable property
        /// </summary>
        System.String DistractorAnalysis { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AllottedTime nullable property
        /// </summary>
        System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepMathComplexityLevel"/> model
        /// </summary>
        Guid? RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReading"/> model
        /// </summary>
        Guid? RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Difficulty nullable property
        /// </summary>
        System.Decimal? Difficulty { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystem"/> model
        /// </summary>
        Guid? RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.TextComplexityValue non nullable property
        /// </summary>
        System.String TextComplexityValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.LinkingItemIndicator nullable property
        /// </summary>
        System.Boolean? LinkingItemIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.ReleaseStatus nullable property
        /// </summary>
        System.Boolean? ReleaseStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Rubric"/> model
        /// </summary>
        Guid? RubricId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentFormSectionItemFieldTestIndicator nullable property
        /// </summary>
        System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get; set; }

    }
}
