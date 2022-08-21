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
    [Table("FacilityMortgageFee")]
    [Index("FacilityMortgageId", "RefFacilityFinancingFeeTypeId", Name = "IX_FacilityMortgage_RefFacilityFinancingFeeType", IsUnique = true)]
    public partial class FacilityMortgageFee
    {
        public FacilityMortgageFee()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
        }

        [Key]
        public int FacilityMortgageFeeId { get; set; }
        public int FacilityMortgageId { get; set; }
        public int RefFacilityFinancingFeeTypeId { get; set; }
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
        [InverseProperty("FacilityMortgageFees")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityMortgageId")]
        [InverseProperty("FacilityMortgageFees")]
        public virtual FacilityMortgage FacilityMortgage { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityMortgageFees")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityFinancingFeeTypeId")]
        [InverseProperty("FacilityMortgageFees")]
        public virtual RefFacilityFinancingFeeType RefFacilityFinancingFeeType { get; set; } = null!;
        [InverseProperty("FacilityMortgageFee")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }
    }
}
