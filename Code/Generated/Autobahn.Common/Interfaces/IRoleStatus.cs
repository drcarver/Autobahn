//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleStatus.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleStatus
     /// </summary>
    public partial interface IRoleStatus
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

        /// <summary>
        /// Defines the RoleStatus.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RoleStatus.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
