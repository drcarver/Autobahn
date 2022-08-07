//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceMediaFeatureModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceMediaFeatureModel Interface
     /// </summary>
    public partial interface ILearningResourceMediaFeatureModel : IAutobahnBase
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
