//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingIndoorAthleticOrPhysEdSpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingIndoorAthleticOrPhysEdSpaceType
     /// </summary>
    public partial interface IRefBuildingIndoorAthleticOrPhysEdSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
