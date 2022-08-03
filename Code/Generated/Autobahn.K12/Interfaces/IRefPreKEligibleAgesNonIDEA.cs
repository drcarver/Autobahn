//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefPreKEligibleAgesNonIDEA.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefPreKEligibleAgesNonIDEA
     /// </summary>
    public partial interface IRefPreKEligibleAgesNonIDEA
    {
        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPreKEligibleAgesNonIDEA.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
