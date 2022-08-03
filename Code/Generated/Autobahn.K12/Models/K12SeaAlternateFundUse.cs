//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaAlternateFundUse.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaAlternateFundUse
     /// </summary>
    public partial class K12SeaAlternateFundUse : IK12SeaAlternateFundUse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaFederalFunds"/> model
        /// </summary>
        public Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

        /// <summary>
        /// Defines the K12SeaAlternateFundUse.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SeaAlternateFundUse.RecordEndDateTime nullable property
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
