//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationWebsite Model
     /// </summary>
    public partial class OrganizationWebsiteModel : AutobahnBase, Interfaces.IOrganizationWebsite
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Web Site Address
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
        /// </para>
        /// </summary>
        public System.String Website { get; set; }

    }
}
