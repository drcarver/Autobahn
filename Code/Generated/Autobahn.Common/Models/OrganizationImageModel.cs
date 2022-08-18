//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationImage Model
     /// </summary>
    public partial class OrganizationImageModel : AutobahnBase, Interfaces.IOrganizationImage
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Organization Image URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20644">Organization Image URL</a>
        /// </para>
        /// </summary>
        public System.String URL { get; set; }

    }
}
