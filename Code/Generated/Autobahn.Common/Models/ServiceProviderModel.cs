//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceProviderModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ServiceProvider Model
     /// </summary>
    public partial class ServiceProviderModel : AutobahnBase, Interfaces.IServiceProvider
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServiceProvided"/> model
        /// </summary>
        public Guid ServiceProvidedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServiceStaff"/> model
        /// </summary>
        public Guid ServiceStaffId { get; set; }

    }
}
