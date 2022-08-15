//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationWebsite Model
     /// </summary>
    public partial class OrganizationWebsiteModel : AutobahnBase, Interfaces.IOrganizationWebsite
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </summary>
        public System.String Website { get; set; }

    }
}
