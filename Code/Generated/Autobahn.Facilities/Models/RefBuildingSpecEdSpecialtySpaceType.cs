//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSpecEdSpecialtySpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingSpecEdSpecialtySpaceType
     /// </summary>
    public partial class RefBuildingSpecEdSpecialtySpaceType : IRefBuildingSpecEdSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingSpecEdSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
