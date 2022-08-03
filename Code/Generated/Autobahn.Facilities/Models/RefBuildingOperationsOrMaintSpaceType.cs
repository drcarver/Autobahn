//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingOperationsOrMaintSpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingOperationsOrMaintSpaceType
     /// </summary>
    public partial class RefBuildingOperationsOrMaintSpaceType : IRefBuildingOperationsOrMaintSpaceType
    {
        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingOperationsOrMaintSpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
