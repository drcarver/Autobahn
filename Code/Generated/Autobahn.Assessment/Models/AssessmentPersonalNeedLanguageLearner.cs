//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedLanguageLearner.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearner
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearner : AutobahnBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
