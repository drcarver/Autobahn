//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDigitalAccess.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccess
     /// </summary>
    public partial interface IPersonDigitalAccess : IAutobahnBase
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

    }
}
