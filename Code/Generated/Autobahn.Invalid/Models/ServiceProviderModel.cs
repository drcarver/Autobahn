//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
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
