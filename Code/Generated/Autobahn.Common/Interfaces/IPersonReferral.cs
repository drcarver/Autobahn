//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonReferral.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonReferral
     /// </summary>
    public partial interface IPersonReferral
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferralDate nullable property
        /// </summary>
        System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// Defines the PersonReferral.Reason non nullable property
        /// </summary>
        System.String Reason { get; set; }

        /// <summary>
        /// Defines the PersonReferral.Source non nullable property
        /// </summary>
        System.String Source { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferralTypeReceived non nullable property
        /// </summary>
        System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferredTo non nullable property
        /// </summary>
        System.String ReferredTo { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcome"/> model
        /// </summary>
        Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// Defines the PersonReferral.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonReferral.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
