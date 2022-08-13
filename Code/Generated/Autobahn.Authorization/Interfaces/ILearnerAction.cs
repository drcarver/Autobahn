//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearnerAction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearnerAction Interface
     /// </summary>
    public partial interface ILearnerAction : IAutobahnBase
    {
        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        System.String Value { get; set; }

    }
}
