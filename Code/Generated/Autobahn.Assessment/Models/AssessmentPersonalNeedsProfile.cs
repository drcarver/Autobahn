//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfile.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile
     /// </summary>
    public partial class AssessmentPersonalNeedsProfile : IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssessmentNeedType non nullable property
        /// </summary>
        public System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssignedSupportFlag nullable property
        /// </summary>
        public System.Boolean? AssignedSupportFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.ActivateByDefault nullable property
        /// </summary>
        public System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.RecordEndDateTime nullable property
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
