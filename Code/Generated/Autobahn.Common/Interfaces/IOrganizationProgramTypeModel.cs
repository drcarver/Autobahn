//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationProgramTypeModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationProgramTypeModel Interface
     /// </summary>
    public partial interface IOrganizationProgramTypeModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefProgramType"/> model
        /// </summary>
        Guid RefProgramTypeId { get; set; }

    }
}
