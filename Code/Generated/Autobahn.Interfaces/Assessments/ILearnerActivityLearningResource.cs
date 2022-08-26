//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   ILearnerActivityLearningResource.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The ILearnerActivityLearningResource Interface
     /// </summary>
    public partial interface ILearnerActivityLearningResource : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
        /// </summary>
        Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

    }
}
