//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingInstructionalSpaceFactorType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingInstructionalSpaceFactorType
     /// </summary>
    public partial class RefBuildingInstructionalSpaceFactorType : IRefBuildingInstructionalSpaceFactorType
    {
        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingInstructionalSpaceFactorType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
