//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationProgramType.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationProgramType
     /// </summary>
    public partial interface IOrganizationProgramType : IAutobahnBase
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
