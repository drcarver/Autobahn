//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationProgramType Model
     /// </summary>
    public partial class OrganizationProgramTypeModel : AutobahnBase, Interfaces.IOrganizationProgramType
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramType"/> model
        /// </summary>
        public Guid RefProgramTypeId { get; set; }

    }
}
