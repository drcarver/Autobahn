//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedLanguageLearner.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedLanguageLearner Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedLanguageLearner : IAutobahnBase
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        Guid AssessmentNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        System.Boolean? AssignedSupport { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    }
}
