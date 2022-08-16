//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContent Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileContent
    {
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
        public Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedSupportToolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefKeywordTranslationsLanguageId { get; set; }

    }
}
