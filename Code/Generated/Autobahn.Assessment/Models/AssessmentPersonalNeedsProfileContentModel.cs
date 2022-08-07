//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContent Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileContentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSupportTool"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSupportToolId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.CognitiveGuidanceActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.CognitiveGuidanceAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ScaffoldingAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ScaffoldingActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ChunkingAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ChunkingActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordEmphasisAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordEmphasisActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ReducedAnswersAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ReducedAnswersActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.NegativesRemovedAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.NegativesRemovedActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationsLanguage"/> model
        /// </summary>
        public Guid? RefKeywordTranslationsLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordTranslationsAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordTranslationsActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
