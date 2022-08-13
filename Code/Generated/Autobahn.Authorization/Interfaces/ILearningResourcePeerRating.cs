//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearningResourcePeerRating.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearningResourcePeerRating Interface
     /// </summary>
    public partial interface ILearningResourcePeerRating : IAutobahnBase
    {
        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        System.DateTime? Date { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        Guid PeerRatingSystemId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        System.Decimal? Value { get; set; }

    }
}
