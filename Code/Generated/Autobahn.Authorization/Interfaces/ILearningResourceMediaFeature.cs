//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearningResourceMediaFeature.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearningResourceMediaFeature Interface
     /// </summary>
    public partial interface ILearningResourceMediaFeature : IAutobahnBase
    {
        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
