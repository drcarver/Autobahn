//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDisability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability
     /// </summary>
    public partial class PersonDisability : IPersonDisability
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
        /// Defines the PersonDisability.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDisability.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDisability.SignificantCognitiveDisabilityIndicator nullable property
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get; set; }

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
