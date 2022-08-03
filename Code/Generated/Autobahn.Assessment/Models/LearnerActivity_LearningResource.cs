//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivity_LearningResource.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The LearnerActivity_LearningResource
     /// </summary>
    public partial class LearnerActivity_LearningResource : ILearnerActivity_LearningResource
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivity"/> model
        /// </summary>
        public Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearnerActivity_LearningResource.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearnerActivity_LearningResource.RecordEndDateTime nullable property
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
