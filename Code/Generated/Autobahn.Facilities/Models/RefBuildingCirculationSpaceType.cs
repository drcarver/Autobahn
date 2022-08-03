//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCirculationSpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingCirculationSpaceType
     /// </summary>
    public partial class RefBuildingCirculationSpaceType : IRefBuildingCirculationSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingCirculationSpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
