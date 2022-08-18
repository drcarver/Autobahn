//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationModel.cs
//* Name:       Application Date
//* Definition: The year, month and day on which an individual  application is received by the organization.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The year, month and day on which an individual  application is received by the organization.
     /// </summary>
    public partial class OrganizationPersonRoleApplicationModel : AutobahnBase, Interfaces.IOrganizationPersonRoleApplication
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
