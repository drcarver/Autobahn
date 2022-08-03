//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityHazardousMaterialsOrCondType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityHazardousMaterialsOrCondType
     /// </summary>
    public partial class RefFacilityHazardousMaterialsOrCondType : IRefFacilityHazardousMaterialsOrCondType
    {
        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
