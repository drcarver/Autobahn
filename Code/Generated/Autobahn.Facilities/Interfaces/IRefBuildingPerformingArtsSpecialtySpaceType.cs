//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingPerformingArtsSpecialtySpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingPerformingArtsSpecialtySpaceType
     /// </summary>
    public partial interface IRefBuildingPerformingArtsSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
