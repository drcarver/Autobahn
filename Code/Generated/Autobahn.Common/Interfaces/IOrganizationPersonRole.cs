//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRole.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRole
     /// </summary>
    public partial interface IOrganizationPersonRole : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Role"/> model
        /// </summary>
        Guid RoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRole.EntryDate nullable property
        /// </summary>
        System.DateTime? EntryDate { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRole.ExitDate nullable property
        /// </summary>
        System.DateTime? ExitDate { get; set; }

    }
}
