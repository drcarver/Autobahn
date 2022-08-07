//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationProgramTypeModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationProgramType Model
     /// </summary>
    public partial class OrganizationProgramTypeModel : AutobahnBase, Interfaces.IOrganizationProgramTypeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefProgramType"/> model
        /// </summary>
        public Guid RefProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
