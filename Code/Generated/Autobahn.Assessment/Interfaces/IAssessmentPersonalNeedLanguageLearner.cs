//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedLanguageLearner.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedLanguageLearner
     /// </summary>
    public partial interface IAssessmentPersonalNeedLanguageLearner : IAutobahnBase
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

    }
}
