//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceAdaptation.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.LearningResources
{
     /// <summary>
     /// The ILearningResourceAdaptation Interface
     /// </summary>
    public partial interface ILearningResourceAdaptation : IAutobahnBase
    {
        System.String AdaptationUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

    }
}
