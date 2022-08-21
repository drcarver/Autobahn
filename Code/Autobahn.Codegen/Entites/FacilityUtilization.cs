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
    [Table("FacilityUtilization")]
    public partial class FacilityUtilization
    {
        [Key]
        public int FacilityUtilizationId { get; set; }
        public int FacilityId { get; set; }
        public int? BuildingHoursOfPublicUsePerWeek { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? BuildingNetAreaOfInstructionalSpace { get; set; }
        public int? BuildingNumberOfTeachingStations { get; set; }
        [StringLength(80)]
        public string? BuildingPublicUsePolicyDescription { get; set; }
        public int? FacilityEnrollmentCapacity { get; set; }
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
        [InverseProperty("FacilityUtilizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityUtilizations")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityUtilizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
