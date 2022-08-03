//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingOutdoorAthleticOrPhysEdSpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingOutdoorAthleticOrPhysEdSpaceType
     /// </summary>
    public partial class RefBuildingOutdoorAthleticOrPhysEdSpaceType : IRefBuildingOutdoorAthleticOrPhysEdSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingOutdoorAthleticOrPhysEdSpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
