using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        [Key]
        public int PersonDisabilityId { get; set; }
        public bool? SignificantCognitiveDisabilityIndicator { get; set; }
        [Column("RefIDEADisabilityTypeId")]
        public int? RefIdeadisabilityTypeId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonDisabilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonDisabilities")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("PrimaryDisabilityTypeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefDisabilityType? PrimaryDisabilityType { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAccommodationsNeededTypeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefAccommodationsNeededType? RefAccommodationsNeededType { get; set; }
        [ForeignKey("RefDisabilityConditionStatusCodeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefDisabilityConditionStatusCode? RefDisabilityConditionStatusCode { get; set; }
        [ForeignKey("RefDisabilityConditionTypeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefDisabilityConditionType? RefDisabilityConditionType { get; set; }
        [ForeignKey("RefDisabilityDeterminationSourceTypeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefDisabilityDeterminationSourceType? RefDisabilityDeterminationSourceType { get; set; }
        [ForeignKey("RefIdeadisabilityTypeId")]
        [InverseProperty("PersonDisabilities")]
        public virtual RefIdeadisabilityType? RefIdeadisabilityType { get; set; }
    }
}
