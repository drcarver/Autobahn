//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   PeerRatingSystem.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The PeerRatingSystem
     /// </summary>
    public partial class PeerRatingSystem : AutobahnBase, Interfaces.IPeerRatingSystem
    {
        /// <summary>
        /// Defines the PeerRatingSystem.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.MaximumValue nullable property
        /// </summary>
        public System.Decimal? MaximumValue { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.MinimumValue non nullable property
        /// </summary>
        public System.Decimal MinimumValue { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.OptimumValue nullable property
        /// </summary>
        public System.Decimal? OptimumValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
