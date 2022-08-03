//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedLanguageLearner.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedLanguageLearner
     /// </summary>
    public partial interface IAssessmentPersonalNeedLanguageLearner
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentNeedsProfileContent"/> model
        /// </summary>
        Guid AssessmentNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.AssignedSupport nullable property
        /// </summary>
        System.Boolean? AssignedSupport { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.ActivateByDefault nullable property
        /// </summary>
        System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerType"/> model
        /// </summary>
        Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.RecordEndDateTime nullable property
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
