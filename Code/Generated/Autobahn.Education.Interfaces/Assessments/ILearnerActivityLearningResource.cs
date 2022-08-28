//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   ILearnerActivityLearningResource.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The ILearnerActivityLearningResource Interface
     /// </summary>
    public partial interface ILearnerActivityLearningResource : IAutobahnBase
    {
        #region ILearnerActivityLearningResource
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
        /// </summary>
        Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        #endregion
    }
}
