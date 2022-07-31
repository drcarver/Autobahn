//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessmentPersonalNeedsProfile.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfile
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// A type of need identified for a learner as part of an assessment need profile.
        /// </summary>
    System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.AssignedSupportFlag nullable property
        /// </summary>
        System.Boolean? AssignedSupportFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.ActivateByDefault nullable property
        /// </summary>
        System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfile.RecordEndDateTime nullable property
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
