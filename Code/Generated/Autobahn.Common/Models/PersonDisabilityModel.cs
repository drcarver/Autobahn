//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDisabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability Model
     /// </summary>
    public partial class PersonDisabilityModel : AutobahnBase, Interfaces.IPersonDisabilityModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityType"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// Defines the PersonDisability.DisabilityStatus nullable property
        /// </summary>
        public System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededType"/> model
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionType"/> model
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceType"/> model
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCode"/> model
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// Defines the PersonDisability.SignificantCognitiveDisabilityIndicator nullable property
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
