//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingLibMediaCenterSpecialtySpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingLibMediaCenterSpecialtySpaceType
     /// </summary>
    public partial interface IRefBuildingLibMediaCenterSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
