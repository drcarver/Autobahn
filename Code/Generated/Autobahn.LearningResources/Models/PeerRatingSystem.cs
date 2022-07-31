//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   PeerRatingSystem.cs
//**********************************************************

using Autobahn.LearningResources.Interfaces;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The PeerRatingSystem
     /// </summary>
    public partial class PeerRatingSystem : IPeerRatingSystem
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PeerRatingSystem"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get; set; }

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
        /// Defines the PeerRatingSystem.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
