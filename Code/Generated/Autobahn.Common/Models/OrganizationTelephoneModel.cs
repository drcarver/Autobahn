//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTelephone Model
     /// </summary>
    public partial class OrganizationTelephoneModel : AutobahnBase, Interfaces.IOrganizationTelephone
    {
        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

    }
}
