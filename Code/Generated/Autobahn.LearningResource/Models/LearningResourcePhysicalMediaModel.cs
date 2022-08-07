//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePhysicalMediaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedia Model
     /// </summary>
    public partial class LearningResourcePhysicalMediaModel : AutobahnBase, Interfaces.ILearningResourcePhysicalMediaModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
