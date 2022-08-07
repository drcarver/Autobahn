//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerActionModel Interface
     /// </summary>
    public partial interface ILearnerActionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// </summary>
        Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// Defines the LearnerAction.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionDateTime nullable property
        /// </summary>
        System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionActorIdentifier non nullable property
        /// </summary>
        System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectDescription non nullable property
        /// </summary>
        System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectIdentifier non nullable property
        /// </summary>
        System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectType non nullable property
        /// </summary>
        System.String LearnerActionObjectType { get; set; }

    }
}
