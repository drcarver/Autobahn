//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvider.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceProvider
     /// </summary>
    public partial class ServiceProvider : IServiceProvider
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceProvided"/> model
        /// </summary>
        public Guid ServiceProvidedId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServiceStaff"/> model
        /// </summary>
        public Guid ServiceStaffId { get; set; }

        /// <summary>
        /// Defines the ServiceProvider.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ServiceProvider.RecordEndDateTime nullable property
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
