//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedLanguageLearner.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearner
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearner : IAssessmentPersonalNeedLanguageLearner
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentNeedsProfileContent"/> model
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.AssignedSupport nullable property
        /// </summary>
        public System.Boolean? AssignedSupport { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.ActivateByDefault nullable property
        /// </summary>
        public System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerType"/> model
        /// </summary>
        public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedLanguageLearner.RecordEndDateTime nullable property
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
