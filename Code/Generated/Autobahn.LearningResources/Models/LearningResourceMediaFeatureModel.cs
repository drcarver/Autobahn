//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceMediaFeature Model
     /// </summary>
    public partial class LearningResourceMediaFeatureModel : AutobahnBase, Interfaces.ILearningResourceMediaFeature
    {
        /// <summary>
        /// Accessible content features included with the learning resource.
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
