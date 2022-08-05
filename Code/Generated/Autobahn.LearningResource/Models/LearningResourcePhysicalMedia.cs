//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePhysicalMedia.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedia
     /// </summary>
    public partial class LearningResourcePhysicalMedia : AutobahnBase, Interfaces.ILearningResourcePhysicalMedia
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
