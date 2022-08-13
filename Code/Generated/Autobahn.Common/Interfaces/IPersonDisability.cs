//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDisability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDisability Interface
     /// </summary>
    public partial interface IPersonDisability : IAutobahnBase
    {
        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
