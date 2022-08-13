//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationProgramType Model
     /// </summary>
    public partial class OrganizationProgramTypeModel : AutobahnBase, Interfaces.IOrganizationProgramType
    {
        /// <summary>
        /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
        /// </summary>
        public Guid RefProgramTypeId { get; set; }

    }
}
