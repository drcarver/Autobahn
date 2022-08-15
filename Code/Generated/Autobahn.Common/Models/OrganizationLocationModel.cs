//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation Model
     /// </summary>
    public partial class OrganizationLocationModel : AutobahnBase, Interfaces.IOrganizationLocation
    {
        /// <summary>
        /// The type of address listed for an organization.
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
