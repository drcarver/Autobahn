//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   ILearnerAction.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The ILearnerAction
     /// </summary>
    public partial interface ILearnerAction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerAction"/> model
        /// </summary>
        Guid LearnerActionId { get; set; }

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
        /// The date and time at which the action was taken.
        /// </summary>
    System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// A unique identifier for the person performing the learner action. The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
        /// </summary>
    System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// A description of the object upon which the person has performed the Learner Action.
        /// </summary>
    System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
        /// </summary>
    System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// The type of object upon which a person has performed the Learner Action.
        /// </summary>
    System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// Defines the LearnerAction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerAction.RecordEndDateTime nullable property
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
