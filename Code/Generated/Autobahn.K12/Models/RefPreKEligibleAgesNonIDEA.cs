//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPreKEligibleAgesNonIDEA.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefPreKEligibleAgesNonIDEA
     /// </summary>
    public partial class RefPreKEligibleAgesNonIDEA : IRefPreKEligibleAgesNonIDEA
    {
        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}