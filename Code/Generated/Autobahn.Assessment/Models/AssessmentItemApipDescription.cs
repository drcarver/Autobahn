//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApipDescription.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemApipDescription
     /// </summary>
    public partial class AssessmentItemApipDescription : IAssessmentItemApipDescription
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.CognitiveGuidanceActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.CognitiveGuidanceAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ScaffoldingAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ScaffoldingActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ChunkingAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ChunkingActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordEmphasisAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordEmphasisActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ReducedAnswersAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ReducedAnswersActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NegativesRemovedAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NegativesRemovedActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordTranslationsAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordTranslationsActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.BrailleIndicator nullable property
        /// </summary>
        public System.Boolean? BrailleIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextOnlyIndicator nullable property
        /// </summary>
        public System.Boolean? TextOnlyIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextOnlyOnDemandIndicator nullable property
        /// </summary>
        public System.Boolean? TextOnlyOnDemandIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextGraphicsIndicator nullable property
        /// </summary>
        public System.Boolean? TextGraphicsIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.GraphicsOnlyIndicator nullable property
        /// </summary>
        public System.Boolean? GraphicsOnlyIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NonVisualIndicator nullable property
        /// </summary>
        public System.Boolean? NonVisualIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.AslIndicator nullable property
        /// </summary>
        public System.Boolean? AslIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.AslOnDemandIndicator nullable property
        /// </summary>
        public System.Boolean? AslOnDemandIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.SignedEnglishIndicator nullable property
        /// </summary>
        public System.Boolean? SignedEnglishIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.SignedEnglishOnDemandIndicator nullable property
        /// </summary>
        public System.Boolean? SignedEnglishOnDemandIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHazardType"/> model
        /// </summary>
        public Guid? RefHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
        /// </summary>
        public Guid? RefSupportToolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
        /// </summary>
        public Guid? RefKeywordTranslationLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
