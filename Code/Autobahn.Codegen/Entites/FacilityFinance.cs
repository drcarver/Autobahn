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
    [Table("FacilityFinance", Schema = "Facilities")]
    public partial class FacilityFinance
    {
        [Key]
        public int FacilityFinanceId { get; set; }
        public int FacilityId { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FacilityReplacementValue { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? IndebtednessAmountAllowed { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InsuranceDeductible { get; set; }
        [Column(TypeName = "decimal(9, 8)")]
        public decimal? PublicEducationMillRate { get; set; }
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
        [InverseProperty("FacilityFinances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityFinances")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityFinances")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
