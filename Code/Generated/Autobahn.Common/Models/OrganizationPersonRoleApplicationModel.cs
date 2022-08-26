//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleApplication Model
     /// </summary>
    public partial class OrganizationPersonRoleApplicationModel : AutobahnBase, IOrganizationPersonRoleApplication
    {
        /// <summary>
        /// Application Date
        /// <para>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
        /// </para>
        /// </summary>
        public System.DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
