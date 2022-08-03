//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonLocationType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPersonLocationType
     /// </summary>
    public partial class RefPersonLocationType : IRefPersonLocationType
    {
        /// <summary>
        /// Defines the RefPersonLocationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Role"/> model
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAddressType"/> model
        /// </summary>
        public Guid? RefAddressTypeId { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPersonLocationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
