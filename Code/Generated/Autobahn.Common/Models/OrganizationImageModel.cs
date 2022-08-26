//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationImage Model
     /// </summary>
    public partial class OrganizationImageModel : AutobahnBase, IOrganizationImage
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.String Url { get; set; }

    }
}
