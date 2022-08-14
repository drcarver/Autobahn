//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceAdaptation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourceAdaptation Interface
     /// </summary>
    public partial interface ILearningResourceAdaptation : IAutobahnBase
    {
        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </summary>
        System.String AdaptationURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </summary>
        Guid LearningResourceId { get; set; }

    }
}
