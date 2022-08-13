//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipContent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipContent Interface
     /// </summary>
    public partial interface IAssessmentNeedApipContent : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        System.Boolean? ReadAtStartPreferenceIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    }
}
