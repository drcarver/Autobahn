//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDisability.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDisability
     /// </summary>
    public partial interface IPersonDisability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityType"/> model
        /// </summary>
        Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// Defines the PersonDisability.DisabilityStatus nullable property
        /// </summary>
        System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededType"/> model
        /// </summary>
        Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionType"/> model
        /// </summary>
        Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceType"/> model
        /// </summary>
        Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCode"/> model
        /// </summary>
        Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// Defines the PersonDisability.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDisability.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDisability.SignificantCognitiveDisabilityIndicator nullable property
        /// </summary>
        System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        Guid? RefIDEADisabilityTypeId { get; set; }

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
