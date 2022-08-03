//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedApipContent.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipContent
     /// </summary>
    public partial interface IAssessmentNeedApipContent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileContent"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileContentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageType"/> model
        /// </summary>
        Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageType"/> model
        /// </summary>
        Guid? KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningType"/> model
        /// </summary>
        Guid? RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationType"/> model
        /// </summary>
        Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceType"/> model
        /// </summary>
        Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.ReadAtStartPreferenceIndicator nullable property
        /// </summary>
        System.Boolean? ReadAtStartPreferenceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceType"/> model
        /// </summary>
        Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.AssessmentNeedDirectionsOnlyIndicator nullable property
        /// </summary>
        System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
