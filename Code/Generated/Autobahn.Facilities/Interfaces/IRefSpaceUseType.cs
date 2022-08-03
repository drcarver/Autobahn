//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefSpaceUseType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefSpaceUseType
     /// </summary>
    public partial interface IRefSpaceUseType
    {
        /// <summary>
        /// Defines the RefSpaceUseType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSpaceUseType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSpaceUseType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSpaceUseType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSpaceUseType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSpaceUseType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
