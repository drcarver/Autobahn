//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceMediaFeature.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourceMediaFeature Interface
     /// </summary>
    public partial interface ILearningResourceMediaFeature : IAutobahnBase
    {
        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
