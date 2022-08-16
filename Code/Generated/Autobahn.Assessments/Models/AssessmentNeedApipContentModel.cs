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
        /// 
        /// </summary>
        public  AssessmentNeedDirectionsOnlyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReadAtStartPreferenceIndicator { get; set; }

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
        public  RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    }
}
