//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceProvided.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvided
     /// </summary>
    public partial interface IServiceProvided
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        Guid ServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServices"/> model
        /// </summary>
        Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Defines the ServiceProvided.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ServiceProvided.RecordEndDateTime nullable property
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
