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
        /// 
        /// </summary>
         AdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AllottedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFormSectionItemFieldTestIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Difficulty { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DistractorAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LinkingItemIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinimumScore { get; set; }

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
        Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReleaseStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Stem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Stimulus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexityValue { get; set; }

    }
}
