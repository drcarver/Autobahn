//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SeaAlternateFundUse.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaAlternateFundUse
     /// </summary>
    public partial interface IK12SeaAlternateFundUse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaFederalFunds"/> model
        /// </summary>
        Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

        /// <summary>
        /// Defines the K12SeaAlternateFundUse.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SeaAlternateFundUse.RecordEndDateTime nullable property
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
