//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipDisplay.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentNeedApipDisplay
     /// </summary>
    public partial class AssessmentNeedApipDisplay : IAssessmentNeedApipDisplay
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.MaskingAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? MaskingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.MaskingActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? MaskingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedMaskingTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementAssignedSupportIndicator nullable property
        /// </summary>
        public System.Boolean? EncouragementAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementActivateByDefaultIndicator nullable property
        /// </summary>
        public System.Boolean? EncouragementActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementTextMessagingString non nullable property
        /// </summary>
        public System.String EncouragementTextMessagingString { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.EncouragementSoundFileUrl non nullable property
        /// </summary>
        public System.String EncouragementSoundFileUrl { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipDisplay.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
