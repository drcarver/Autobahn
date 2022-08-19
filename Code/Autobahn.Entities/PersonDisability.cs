using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDisability")]
    public partial class PersonDisability
    {
        public int PersonId { get; set; }

        public int? PrimaryDisabilityTypeId { get; set; }

        public bool? DisabilityStatus { get; set; }

        public int? RefAccommodationsNeededTypeId { get; set; }

        public int? RefDisabilityConditionTypeId { get; set; }

        public int? RefDisabilityDeterminationSourceTypeId { get; set; }

        public int? RefDisabilityConditionStatusCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int PersonDisabilityId { get; set; }

        public bool? SignificantCognitiveDisabilityIndicator { get; set; }

        public int? RefIDEADisabilityTypeId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAccommodationsNeededType RefAccommodationsNeededType { get; set; }

        public virtual RefDisabilityConditionStatusCode RefDisabilityConditionStatusCode { get; set; }

        public virtual RefDisabilityConditionType RefDisabilityConditionType { get; set; }

        public virtual RefDisabilityDeterminationSourceType RefDisabilityDeterminationSourceType { get; set; }

        public virtual RefDisabilityType RefDisabilityType { get; set; }

        public virtual RefIDEADisabilityType RefIDEADisabilityType { get; set; }
    }
}
