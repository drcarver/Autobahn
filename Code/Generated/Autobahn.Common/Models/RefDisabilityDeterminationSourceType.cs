//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityDeterminationSourceType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefDisabilityDeterminationSourceType
     /// </summary>
    public partial class RefDisabilityDeterminationSourceType : IRefDisabilityDeterminationSourceType
    {
        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDisabilityDeterminationSourceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}