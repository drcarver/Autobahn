//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceProvider.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvider
     /// </summary>
    public partial interface IServiceProvider
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceProvided"/> model
        /// </summary>
        Guid ServiceProvidedId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceStaff"/> model
        /// </summary>
        Guid ServiceStaffId { get; set; }

        /// <summary>
        /// Defines the ServiceProvider.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ServiceProvider.RecordEndDateTime nullable property
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
