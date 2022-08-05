//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvider.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceProvider
     /// </summary>
    public partial class ServiceProvider : AutobahnBase, Interfaces.IServiceProvider
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
