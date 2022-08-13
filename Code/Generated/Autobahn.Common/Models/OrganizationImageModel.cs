//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationImage Model
     /// </summary>
    public partial class OrganizationImageModel : AutobahnBase, Interfaces.IOrganizationImage
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
        /// </summary>
        public System.String URL { get; set; }

    }
}
