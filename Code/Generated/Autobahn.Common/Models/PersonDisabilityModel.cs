//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability Model
     /// </summary>
    public partial class PersonDisabilityModel : AutobahnBase, Interfaces.IPersonDisability
    {
        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
