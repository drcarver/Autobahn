//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItem Model
     /// </summary>
    public partial class AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentItemModel
    {
        /// <summary>
        /// Defines the AssessmentItem.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentItemBankName non nullable property
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemType"/> model
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.BodyText non nullable property
        /// </summary>
        public System.String BodyText { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Stimulus non nullable property
        /// </summary>
        public System.String Stimulus { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Stem non nullable property
        /// </summary>
        public System.String Stem { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AdaptiveIndicator nullable property
        /// </summary>
        public System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.MaximumScore non nullable property
        /// </summary>
        public System.String MaximumScore { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.MinimumScore non nullable property
        /// </summary>
        public System.String MinimumScore { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.DistractorAnalysis non nullable property
        /// </summary>
        public System.String DistractorAnalysis { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AllottedTime nullable property
        /// </summary>
        public System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepMathComplexityLevel"/> model
        /// </summary>
        public Guid? RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReading"/> model
        /// </summary>
        public Guid? RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.Difficulty nullable property
        /// </summary>
        public System.Decimal? Difficulty { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystem"/> model
        /// </summary>
        public Guid? RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.TextComplexityValue non nullable property
        /// </summary>
        public System.String TextComplexityValue { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.LinkingItemIndicator nullable property
        /// </summary>
        public System.Boolean? LinkingItemIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.ReleaseStatus nullable property
        /// </summary>
        public System.Boolean? ReleaseStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid? RubricId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentItem.AssessmentFormSectionItemFieldTestIndicator nullable property
        /// </summary>
        public System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
