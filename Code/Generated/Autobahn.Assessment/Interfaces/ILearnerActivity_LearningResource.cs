//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerActivity_LearningResource.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerActivity_LearningResource
     /// </summary>
    public partial interface ILearnerActivity_LearningResource : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivity"/> model
        /// </summary>
        Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

    }
}
