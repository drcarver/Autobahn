//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerAction.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The LearnerAction
     /// </summary>
    public partial class LearnerAction : ILearnerAction
    {
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
        /// Defines the LearnerAction.LearnerActionDateTime nullable property
        /// </summary>
        public System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionActorIdentifier non nullable property
        /// </summary>
        public System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectDescription non nullable property
        /// </summary>
        public System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectIdentifier non nullable property
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// Defines the LearnerAction.LearnerActionObjectType non nullable property
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
