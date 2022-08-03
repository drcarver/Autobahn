//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityStateOrLocalMandateInterestType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityStateOrLocalMandateInterestType
     /// </summary>
    public partial class RefFacilityStateOrLocalMandateInterestType : IRefFacilityStateOrLocalMandateInterestType
    {
        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
