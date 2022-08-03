//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatus.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefRoleStatus
     /// </summary>
    public partial class RefRoleStatus : IRefRoleStatus
    {
        /// <summary>
        /// Defines the RefRoleStatus.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
        /// </summary>
        public Guid? RefRoleStatusTypeId { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefRoleStatus.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
