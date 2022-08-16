//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipControl.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipControl Interface
     /// </summary>
    public partial interface IAssessmentNeedApipControl : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LineReaderHighlightColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OverlayColor { get; set; }

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
         RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    }
}
