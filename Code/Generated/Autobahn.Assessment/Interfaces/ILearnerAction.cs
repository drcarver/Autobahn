//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerAction.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerAction
     /// </summary>
    public partial interface ILearnerAction
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
