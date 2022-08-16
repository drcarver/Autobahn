//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileContent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileContent Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileContent : IAutobahnBase
    {
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
        Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedSupportToolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefKeywordTranslationsLanguageId { get; set; }

    }
}
