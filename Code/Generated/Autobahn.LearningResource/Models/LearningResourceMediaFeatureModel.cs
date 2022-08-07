//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceMediaFeatureModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourceMediaFeature Model
     /// </summary>
    public partial class LearningResourceMediaFeatureModel : AutobahnBase, Interfaces.ILearningResourceMediaFeatureModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourceMediaFeatureType"/> model
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
