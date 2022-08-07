//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceAdaptationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourceAdaptation Model
     /// </summary>
    public partial class LearningResourceAdaptationModel : AutobahnBase, Interfaces.ILearningResourceAdaptationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearningResourceAdaptation.AdaptationURL non nullable property
        /// </summary>
        public System.String AdaptationURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
