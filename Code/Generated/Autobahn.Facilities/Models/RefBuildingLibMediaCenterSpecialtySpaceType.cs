//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingLibMediaCenterSpecialtySpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingLibMediaCenterSpecialtySpaceType
     /// </summary>
    public partial class RefBuildingLibMediaCenterSpecialtySpaceType : IRefBuildingLibMediaCenterSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingLibMediaCenterSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
