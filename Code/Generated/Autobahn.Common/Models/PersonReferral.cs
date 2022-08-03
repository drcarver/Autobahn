//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonReferral.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonReferral
     /// </summary>
    public partial class PersonReferral : IPersonReferral
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferralDate nullable property
        /// </summary>
        public System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// Defines the PersonReferral.Reason non nullable property
        /// </summary>
        public System.String Reason { get; set; }

        /// <summary>
        /// Defines the PersonReferral.Source non nullable property
        /// </summary>
        public System.String Source { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferralTypeReceived non nullable property
        /// </summary>
        public System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// Defines the PersonReferral.ReferredTo non nullable property
        /// </summary>
        public System.String ReferredTo { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcome"/> model
        /// </summary>
        public Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// Defines the PersonReferral.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonReferral.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
