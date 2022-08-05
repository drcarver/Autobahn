//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivity_LearningResource.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The LearnerActivity_LearningResource
     /// </summary>
    public partial class LearnerActivity_LearningResource : AutobahnBase, Interfaces.ILearnerActivity_LearningResource
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
