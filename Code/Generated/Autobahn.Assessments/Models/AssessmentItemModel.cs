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
        /// 
        /// </summary>
        public  AdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AllottedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFormSectionItemFieldTestIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentItemBankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Difficulty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DistractorAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LinkingItemIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinimumScore { get; set; }

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
        public Guid? RefAssessmentItemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNaepAspectsOfReadingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTextComplexitySystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReleaseStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Stem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Stimulus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexityValue { get; set; }

    }
}
