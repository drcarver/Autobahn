//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleFTE Model
     /// </summary>
    public partial class OrganizationPersonRoleFTEModel : AutobahnBase, Interfaces.IOrganizationPersonRoleFTE
    {
        /// <summary>
        /// Full Time Equivalency
        /// <para>
        /// The time a person is enrolled, employed, involved, or participates in the organization, divided by the time the organization defines as full-time for that role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20906">Full Time Equivalency</a>
        /// </para>
        /// </summary>
        public System.Decimal FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
