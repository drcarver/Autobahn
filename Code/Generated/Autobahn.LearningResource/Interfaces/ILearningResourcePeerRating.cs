//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourcePeerRating.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourcePeerRating
     /// </summary>
    public partial interface ILearningResourcePeerRating : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PeerRatingSystem"/> model
        /// </summary>
        Guid PeerRatingSystemId { get; set; }

        /// <summary>
        /// Defines the LearningResourcePeerRating.Value nullable property
        /// </summary>
        System.Decimal? Value { get; set; }

        /// <summary>
        /// Defines the LearningResourcePeerRating.Date nullable property
        /// </summary>
        System.DateTime? Date { get; set; }

    }
}