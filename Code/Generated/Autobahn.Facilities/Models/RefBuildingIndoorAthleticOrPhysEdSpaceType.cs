//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingIndoorAthleticOrPhysEdSpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingIndoorAthleticOrPhysEdSpaceType
     /// </summary>
    public partial class RefBuildingIndoorAthleticOrPhysEdSpaceType : IRefBuildingIndoorAthleticOrPhysEdSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingIndoorAthleticOrPhysEdSpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
