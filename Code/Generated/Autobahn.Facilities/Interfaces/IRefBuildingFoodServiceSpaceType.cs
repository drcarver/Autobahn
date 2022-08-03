//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingFoodServiceSpaceType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingFoodServiceSpaceType
     /// </summary>
    public partial interface IRefBuildingFoodServiceSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}