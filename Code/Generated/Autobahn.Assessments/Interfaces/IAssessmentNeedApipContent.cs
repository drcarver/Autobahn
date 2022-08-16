//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipContent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipContent Interface
     /// </summary>
    public partial interface IAssessmentNeedApipContent : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReadAtStartPreferenceIndicator { get; set; }

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
         RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    }
}
