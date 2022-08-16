//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipDisplay.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipDisplay Interface
     /// </summary>
    public partial interface IAssessmentNeedApipDisplay : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EncouragementActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? EncouragementAssignedSupportIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EncouragementSoundFileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EncouragementTextMessagingString { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaskingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaskingAssignedSupportIndicator { get; set; }

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
         RefAssessmentNeedMaskingTypeId { get; set; }

    }
}
