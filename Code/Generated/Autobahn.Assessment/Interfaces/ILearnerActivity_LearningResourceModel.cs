//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   ILearnerActivity_LearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The ILearnerActivity_LearningResourceModel Interface
     /// </summary>
    public partial interface ILearnerActivity_LearningResourceModel : IAutobahnBase
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
