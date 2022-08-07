//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleStatusModel Interface
     /// </summary>
    public partial interface IRoleStatusModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the RoleStatus.StatusStartDate non nullable property
        /// </summary>
        System.DateTime StatusStartDate { get; set; }

        /// <summary>
        /// Defines the RoleStatus.StatusEndDate nullable property
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatus"/> model
        /// </summary>
        Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
