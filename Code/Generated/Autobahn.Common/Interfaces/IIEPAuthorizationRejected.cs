//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIEPAuthorizationRejected.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected
     /// </summary>
    public partial interface IIEPAuthorizationRejected
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IEPAuthorization"/> model
        /// </summary>
        Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionDescription non nullable property
        /// </summary>
        System.String PortionDescription { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionExplanation non nullable property
        /// </summary>
        System.String PortionExplanation { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.RecordEndDateTime nullable property
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
