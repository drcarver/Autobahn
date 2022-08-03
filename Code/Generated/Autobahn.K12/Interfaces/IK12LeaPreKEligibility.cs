//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaPreKEligibility.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibility
     /// </summary>
    public partial interface IK12LeaPreKEligibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibility"/> model
        /// </summary>
        Guid K12LEAPreKEligibilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// </summary>
        Guid RefPrekindergartenEligibilityId { get; set; }

        /// <summary>
        /// Defines the K12LeaPreKEligibility.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaPreKEligibility.RecordEndDateTime nullable property
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
