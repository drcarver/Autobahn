//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedApipDisplayModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipDisplayModel Interface
     /// </summary>
    public partial interface IAssessmentNeedApipDisplayModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.MaskingAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? MaskingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.MaskingActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? MaskingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingType"/> model
        /// </summary>
        Guid? RefAssessmentNeedMaskingTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? EncouragementAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? EncouragementActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementTextMessagingString non nullable property
        /// </summary>
        System.String EncouragementTextMessagingString { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementSoundFileUrl non nullable property
        /// </summary>
        System.String EncouragementSoundFileUrl { get; set; }

    }
}
