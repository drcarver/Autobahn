//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   IPeerRatingSystem.cs
//**********************************************************

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The IPeerRatingSystem
     /// </summary>
    public partial Interface IPeerRatingSystem
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PeerRatingSystem"/> model
        /// </summary>
        Guid PeerRatingSystemId { get; set; }

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

        /// <summary>
        /// Defines the PeerRatingSystem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PeerRatingSystem.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
