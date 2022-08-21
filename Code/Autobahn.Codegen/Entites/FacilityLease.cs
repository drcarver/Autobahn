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
    [Table("FacilityLease")]
    public partial class FacilityLease
    {
        public FacilityLease()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
        }

        [Key]
        public int FacilityLeaseId { get; set; }
        public int FacilityId { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FacilityLeaseAmount { get; set; }
        public int? RefFacilityLeaseAmountCategoryId { get; set; }
        public int? RefFacilityLeaseTypeId { get; set; }
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
        [InverseProperty("FacilityLeases")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityLeases")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityLeases")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityLeaseAmountCategoryId")]
        [InverseProperty("FacilityLeases")]
        public virtual RefFacilityLeaseAmountCategory? RefFacilityLeaseAmountCategory { get; set; }
        [ForeignKey("RefFacilityLeaseTypeId")]
        [InverseProperty("FacilityLeases")]
        public virtual RefFacilityLeaseType? RefFacilityLeaseType { get; set; }
        [InverseProperty("FacilityLease")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }
    }
}
