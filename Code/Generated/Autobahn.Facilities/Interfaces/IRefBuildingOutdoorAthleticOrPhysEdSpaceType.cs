//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingOutdoorAthleticOrPhysEdSpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingOutdoorAthleticOrPhysEdSpaceType
     /// </summary>
    public partial interface IRefBuildingOutdoorAthleticOrPhysEdSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
