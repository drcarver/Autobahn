//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipDescriptionModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemApipDescription Model
     /// </summary>
    public partial class AssessmentItemApipDescriptionModel : IAssessmentItemApipDescription
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IAssessmentItemApipDescription
        public Boolean? AslIndicator { get; set; }

        public Boolean? AslOnDemandIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        public Boolean? BrailleIndicator { get; set; }

        public Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        public Boolean? ChunkingAssignedSupportIndicator { get; set; }

        public Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        public Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        public Boolean? GraphicsOnlyIndicator { get; set; }

        public Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        public Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        public Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        public Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        public Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        public Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        public Boolean? NonVisualIndicator { get; set; }

        public Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        public Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHazardType"/> model
        /// </summary>
        public Guid? RefHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
        /// </summary>
        public Guid? RefKeywordTranslationLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
        /// </summary>
        public Guid? RefSupportToolTypeId { get; set; }

        public Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        public Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        public Boolean? SignedEnglishIndicator { get; set; }

        public Boolean? SignedEnglishOnDemandIndicator { get; set; }

        public Boolean? TextGraphicsIndicator { get; set; }

        public Boolean? TextOnlyIndicator { get; set; }

        public Boolean? TextOnlyOnDemandIndicator { get; set; }

        #endregion
    }
}
