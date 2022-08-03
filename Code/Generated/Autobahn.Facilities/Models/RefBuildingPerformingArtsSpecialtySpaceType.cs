//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingPerformingArtsSpecialtySpaceType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingPerformingArtsSpecialtySpaceType
     /// </summary>
    public partial class RefBuildingPerformingArtsSpecialtySpaceType : IRefBuildingPerformingArtsSpecialtySpaceType
    {
        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingPerformingArtsSpecialtySpaceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
