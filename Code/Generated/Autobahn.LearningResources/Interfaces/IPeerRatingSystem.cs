//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   IPeerRatingSystem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The IPeerRatingSystem Interface
     /// </summary>
    public partial interface IPeerRatingSystem : IAutobahnBase
    {
        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        System.Decimal? MaximumValue { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        System.Decimal MinimumValue { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        System.Decimal? OptimumValue { get; set; }

    }
}
