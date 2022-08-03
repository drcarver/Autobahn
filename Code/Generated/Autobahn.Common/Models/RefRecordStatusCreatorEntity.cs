//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusCreatorEntity.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefRecordStatusCreatorEntity
     /// </summary>
    public partial class RefRecordStatusCreatorEntity : IRefRecordStatusCreatorEntity
    {
        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
