//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourceMediaFeatureModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearningResourceMediaFeature Model
     /// </summary>
    public partial class LearningResourceMediaFeatureModel : AutobahnBase, Interfaces.ILearningResourceMediaFeature
    {
        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
