//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingEnvOrEnergyPerformanceRatingCat.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingEnvOrEnergyPerformanceRatingCat
     /// </summary>
    public partial interface IRefBuildingEnvOrEnergyPerformanceRatingCat
    {
        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
