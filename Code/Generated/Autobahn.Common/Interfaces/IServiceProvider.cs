//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceProvider.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvider
     /// </summary>
    public partial interface IServiceProvider : IAutobahnBase
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

    }
}
