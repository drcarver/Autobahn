//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefRecordStatusCreatorEntity.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefRecordStatusCreatorEntity
     /// </summary>
    public partial interface IRefRecordStatusCreatorEntity
    {
        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefRecordStatusCreatorEntity.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
