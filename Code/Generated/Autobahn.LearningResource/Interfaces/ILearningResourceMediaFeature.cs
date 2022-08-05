//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceMediaFeature.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceMediaFeature
     /// </summary>
    public partial interface ILearningResourceMediaFeature : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourceMediaFeatureType"/> model
        /// </summary>
        Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
