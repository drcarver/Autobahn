//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationAccreditation Model
     /// </summary>
    public partial class OrganizationAccreditationModel : AutobahnBase, Interfaces.IOrganizationAccreditation
    {
        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
