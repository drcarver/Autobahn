//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentNeedApipContent Model
     /// </summary>
    public partial class AssessmentNeedApipContentModel : AutobahnBase, Interfaces.IAssessmentNeedApipContentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileContent"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileContentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageType"/> model
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageType"/> model
        /// </summary>
        public Guid? KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.ReadAtStartPreferenceIndicator nullable property
        /// </summary>
        public System.Boolean? ReadAtStartPreferenceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipContent.AssessmentNeedDirectionsOnlyIndicator nullable property
        /// </summary>
        public System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
