//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearnerActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearnerAction Model
     /// </summary>
    public partial class LearnerActionModel : AutobahnBase, Interfaces.ILearnerAction
    {
        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public System.String Value { get; set; }

    }
}
