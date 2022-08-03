//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPersonLocationType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPersonLocationType
     /// </summary>
    public partial interface IRefPersonLocationType
    {
        /// <summary>
        /// Defines the RefPersonLocationType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Role"/> model
        /// </summary>
        Guid? RoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAddressType"/> model
        /// </summary>
        Guid? RefAddressTypeId { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
