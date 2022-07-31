//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   LearnerAction.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerAction
     /// </summary>
    public partial class LearnerAction : ILearnerAction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerAction"/> model
        /// </summary>
        public Guid LearnerActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// Defines the LearnerAction.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// The date and time at which the action was taken.
        /// </summary>
    public System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// A unique identifier for the person performing the learner action. The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
        /// </summary>
    public System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// A description of the object upon which the person has performed the Learner Action.
        /// </summary>
    public System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
        /// </summary>
    public System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// The type of object upon which a person has performed the Learner Action.
        /// </summary>
    public System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// Defines the LearnerAction.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerAction.RecordEndDateTime nullable property
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
