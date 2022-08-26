//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation Model
     /// </summary>
    public partial class OrganizationLocationModel : AutobahnBase, IOrganizationLocation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Address Type for Organization
        /// <para>
        /// The type of address listed for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
        /// </para>
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
