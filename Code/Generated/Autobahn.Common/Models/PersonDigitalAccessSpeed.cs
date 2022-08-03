//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeed.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDigitalAccessSpeed
     /// </summary>
    public partial class PersonDigitalAccessSpeed : IPersonDigitalAccessSpeed
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
        /// Defines the PersonDigitalAccessSpeed.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.RecordEndDateTime nullable property
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
