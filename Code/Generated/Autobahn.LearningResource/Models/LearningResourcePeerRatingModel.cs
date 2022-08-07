//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePeerRatingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResourcePeerRating Model
     /// </summary>
    public partial class LearningResourcePeerRatingModel : AutobahnBase, Interfaces.ILearningResourcePeerRatingModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PeerRatingSystem"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get; set; }

        /// <summary>
        /// Defines the LearningResourcePeerRating.Value nullable property
        /// </summary>
        public System.Decimal? Value { get; set; }

        /// <summary>
        /// Defines the LearningResourcePeerRating.Date nullable property
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
