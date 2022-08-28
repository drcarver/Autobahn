//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceAdaptation.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.LearningResources
{
     /// <summary>
     /// The ILearningResourceAdaptation Interface
     /// </summary>
    public partial interface ILearningResourceAdaptation : IAutobahnBase
    {
        #region ILearningResourceAdaptation
        System.String AdaptationUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        #endregion
    }
}
