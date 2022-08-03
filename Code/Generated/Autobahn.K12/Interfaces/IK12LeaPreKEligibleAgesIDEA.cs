//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaPreKEligibleAgesIDEA.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibleAgesIDEA
     /// </summary>
    public partial interface IK12LeaPreKEligibleAgesIDEA
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibleAgesIDEA"/> model
        /// </summary>
        Guid K12LEAPreKEligibleAgesIDEAId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPreKEligibleAgesNonIDEA"/> model
        /// </summary>
        Guid RefPreKEligibleAgesNonIDEAId { get; set; }

        /// <summary>
        /// Defines the K12LeaPreKEligibleAgesIDEA.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaPreKEligibleAgesIDEA.RecordEndDateTime nullable property
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
