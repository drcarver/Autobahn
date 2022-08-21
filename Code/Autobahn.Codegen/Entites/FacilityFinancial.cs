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
    [Table("FacilityFinancial")]
    public partial class FacilityFinancial
    {
        [Key]
        public int FacilityFinancialId { get; set; }
        public int OrganizationFinancialId { get; set; }
        public int? FacilityLeaseId { get; set; }
        public int? FacilityMortgageId { get; set; }
        public int? FacilityMortgageFeeId { get; set; }
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
        [InverseProperty("FacilityFinancials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityLeaseId")]
        [InverseProperty("FacilityFinancials")]
        public virtual FacilityLease? FacilityLease { get; set; }
        [ForeignKey("FacilityMortgageId")]
        [InverseProperty("FacilityFinancials")]
        public virtual FacilityMortgage? FacilityMortgage { get; set; }
        [ForeignKey("FacilityMortgageFeeId")]
        [InverseProperty("FacilityFinancials")]
        public virtual FacilityMortgageFee? FacilityMortgageFee { get; set; }
        [ForeignKey("OrganizationFinancialId")]
        [InverseProperty("FacilityFinancials")]
        public virtual OrganizationFinancial OrganizationFinancial { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityFinancials")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
