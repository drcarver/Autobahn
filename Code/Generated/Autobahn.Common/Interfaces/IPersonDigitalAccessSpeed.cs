//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDigitalAccessSpeed.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccessSpeed
     /// </summary>
    public partial interface IPersonDigitalAccessSpeed
    {
        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetDownloadSpeed nullable property
        /// </summary>
        System.Decimal? InternetDownloadSpeed { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetSpeedTestDateTime nullable property
        /// </summary>
        System.DateTime? InternetSpeedTestDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.InternetUploadSpeed nullable property
        /// </summary>
        System.Decimal? InternetUploadSpeed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDigitalAccess"/> model
        /// </summary>
        Guid? PersonDigitalAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonLearningDevice"/> model
        /// </summary>
        Guid? PersonLearningDeviceId { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccessSpeed.RecordEndDateTime nullable property
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
