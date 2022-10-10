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
    [Table("ServiceFrequency", Schema = "Education.Common")]
    public partial class ServiceFrequency
    {
        [Key]
        public int ServiceFrequencyId { get; set; }
        public int ServicePlanId { get; set; }
        public int? DurationInMinutes { get; set; }
        public int? FrequencyLength { get; set; }
        public int? InstancesPerCycle { get; set; }
        public int? RefFrequencyUnitId { get; set; }

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
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ServiceFrequencies")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServiceFrequencies")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFrequencyUnitId")]
        [InverseProperty("ServiceFrequencies")]
        public virtual RefFrequencyUnit? RefFrequencyUnit { get; set; }
        [ForeignKey("ServicePlanId")]
        [InverseProperty("ServiceFrequencies")]
        public virtual ServicePlan ServicePlan { get; set; } = null!;
    }
}
