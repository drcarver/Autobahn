//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   IPeerRatingSystem.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The IPeerRatingSystem
     /// </summary>
    public partial interface IPeerRatingSystem : IAutobahnBase
    {
        /// <summary>
        /// Defines the PeerRatingSystem.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.MaximumValue nullable property
        /// </summary>
        System.Decimal? MaximumValue { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.MinimumValue non nullable property
        /// </summary>
        System.Decimal MinimumValue { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.OptimumValue nullable property
        /// </summary>
        System.Decimal? OptimumValue { get; set; }

    }
}
