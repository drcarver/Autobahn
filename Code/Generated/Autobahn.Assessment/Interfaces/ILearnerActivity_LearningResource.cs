//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerActivity_LearningResource.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerActivity_LearningResource
     /// </summary>
    public partial interface ILearnerActivity_LearningResource
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivity"/> model
        /// </summary>
        Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity_LearningResource.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity_LearningResource.RecordEndDateTime nullable property
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
