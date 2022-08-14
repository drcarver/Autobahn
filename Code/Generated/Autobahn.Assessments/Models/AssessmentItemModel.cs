//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItem Model
     /// </summary>
    public partial class AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentItem
    {
        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? AdaptiveIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String BodyText { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Decimal? Difficulty { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String DistractorAnalysis { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? LinkingItemIndicator { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String MaximumScore { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String MinimumScore { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? ReleaseStatus { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RubricId { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Stem { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Stimulus { get; set; }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String TextComplexityValue { get; set; }

    }
}
