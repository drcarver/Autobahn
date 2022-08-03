//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleFTE.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleFTE
     /// </summary>
    public partial interface IOrganizationPersonRoleFTE
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.FullTimeEquivalency non nullable property
        /// </summary>
        System.Decimal FullTimeEquivalency { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.RecordEndDateTime nullable property
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
