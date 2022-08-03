//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDigitalAccess.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccess
     /// </summary>
    public partial interface IPersonDigitalAccess
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccess.InternetAccessInResidence nullable property
        /// </summary>
        System.Boolean? InternetAccessInResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddress"/> model
        /// </summary>
        Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToInternetAccessInResidence"/> model
        /// </summary>
        Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessTypeInResidence"/> model
        /// </summary>
        Guid? RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetPerformanceInResidence"/> model
        /// </summary>
        Guid? RefInternetPerformanceInResidenceId { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccess.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDigitalAccess.RecordEndDateTime nullable property
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
