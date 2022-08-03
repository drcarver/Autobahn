//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedApipDisplay.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipDisplay
     /// </summary>
    public partial interface IAssessmentNeedApipDisplay
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

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
