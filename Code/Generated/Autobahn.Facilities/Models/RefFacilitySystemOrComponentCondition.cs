//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitySystemOrComponentCondition.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilitySystemOrComponentCondition
     /// </summary>
    public partial class RefFacilitySystemOrComponentCondition : IRefFacilitySystemOrComponentCondition
    {
        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilitySystemOrComponentCondition.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
