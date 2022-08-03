//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefRoleStatus.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefRoleStatus
     /// </summary>
    public partial interface IRefRoleStatus
    {
        /// <summary>
        /// Defines the RefRoleStatus.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
        /// </summary>
        Guid? RefRoleStatusTypeId { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
