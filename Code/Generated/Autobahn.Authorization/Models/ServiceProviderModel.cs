//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServiceProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ServiceProvider Model
     /// </summary>
    public partial class ServiceProviderModel : AutobahnBase, Interfaces.IServiceProvider
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid ServiceProvidedId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid ServiceStaffId { get; set; }

    }
}
