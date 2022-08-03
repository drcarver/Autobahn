//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRole.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRole
     /// </summary>
    public partial interface IOrganizationPersonRole
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

        /// <summary>
        /// Defines the OrganizationPersonRole.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRole.RecordEndDateTime nullable property
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
