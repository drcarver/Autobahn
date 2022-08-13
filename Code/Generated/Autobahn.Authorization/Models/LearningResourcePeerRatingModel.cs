//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourcePeerRatingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearningResourcePeerRating Model
     /// </summary>
    public partial class LearningResourcePeerRatingModel : AutobahnBase, Interfaces.ILearningResourcePeerRating
    {
        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public Guid PeerRatingSystemId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public System.Decimal? Value { get; set; }

    }
}
