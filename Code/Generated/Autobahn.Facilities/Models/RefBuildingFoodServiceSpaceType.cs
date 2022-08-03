//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingFoodServiceSpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingFoodServiceSpaceType
     /// </summary>
    public partial class RefBuildingFoodServiceSpaceType : IRefBuildingFoodServiceSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingFoodServiceSpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
