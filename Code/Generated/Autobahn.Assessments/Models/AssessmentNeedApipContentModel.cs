//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipContent Model
     /// </summary>
    public partial class AssessmentNeedApipContentModel : AutobahnBase, Interfaces.IAssessmentNeedApipContent
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public System.Boolean? ReadAtStartPreferenceIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    }
}
