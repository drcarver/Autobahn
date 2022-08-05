//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeed.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDigitalAccessSpeed
     /// </summary>
    public partial class PersonDigitalAccessSpeed : AutobahnBase, Interfaces.IPersonDigitalAccessSpeed
    {
        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetDownloadSpeed nullable property
        /// </summary>
        public System.Decimal? InternetDownloadSpeed { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetSpeedTestDateTime nullable property
        /// </summary>
        public System.DateTime? InternetSpeedTestDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetUploadSpeed nullable property
        /// </summary>
        public System.Decimal? InternetUploadSpeed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDigitalAccess"/> model
        /// </summary>
        public Guid? PersonDigitalAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonLearningDevice"/> model
        /// </summary>
        public Guid? PersonLearningDeviceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
