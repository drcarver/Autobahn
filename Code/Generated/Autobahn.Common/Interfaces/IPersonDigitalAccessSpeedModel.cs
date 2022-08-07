//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDigitalAccessSpeedModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccessSpeedModel Interface
     /// </summary>
    public partial interface IPersonDigitalAccessSpeedModel : IAutobahnBase
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

    }
}
