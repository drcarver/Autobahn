//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The PeerRatingSystem Model
     /// </summary>
    public partial class PeerRatingSystemModel : AutobahnBase, Interfaces.IPeerRatingSystem
    {
        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal? MaximumValue { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal MinimumValue { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal? OptimumValue { get; set; }

    }
}
