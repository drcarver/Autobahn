using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentNeedApipContent")]
    public partial class AssessmentNeedApipContent
    {
        public int AssessmentNeedApipContentId { get; set; }

        public int AssessmentPersonalNeedsProfileContentId { get; set; }

        public int? ItemTranslationDisplayLanguageTypeId { get; set; }

        public int? KeywordTranslationLanguageTypeId { get; set; }

        public int? RefAssessmentNeedSigningTypeId { get; set; }

        public int? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        public int? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        public bool? ReadAtStartPreferenceIndicator { get; set; }

        public int? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

        public bool? AssessmentNeedDirectionsOnlyIndicator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentNeedSigningType RefAssessmentNeedSigningType { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefLanguage RefLanguage1 { get; set; }

        public virtual AssessmentPersonalNeedsProfileContent AssessmentPersonalNeedsProfileContent { get; set; }

        public virtual RefAssessmentNeedAlternativeRepresentationType RefAssessmentNeedAlternativeRepresentationType { get; set; }

        public virtual RefAssessmentNeedSpokenSourcePreferenceType RefAssessmentNeedSpokenSourcePreferenceType { get; set; }

        public virtual RefAssessmentNeedUserSpokenPreferenceType RefAssessmentNeedUserSpokenPreferenceType { get; set; }
    }
}
