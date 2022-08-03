//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingEnvOrEnergyPerformanceRatingCat.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingEnvOrEnergyPerformanceRatingCat
     /// </summary>
    public partial class RefBuildingEnvOrEnergyPerformanceRatingCat : IRefBuildingEnvOrEnergyPerformanceRatingCat
    {
        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingEnvOrEnergyPerformanceRatingCat.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
