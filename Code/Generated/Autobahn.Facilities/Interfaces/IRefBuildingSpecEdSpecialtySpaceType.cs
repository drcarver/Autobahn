//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingSpecEdSpecialtySpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingSpecEdSpecialtySpaceType
     /// </summary>
    public partial interface IRefBuildingSpecEdSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
