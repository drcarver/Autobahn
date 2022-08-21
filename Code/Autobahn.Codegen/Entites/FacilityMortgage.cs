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
    [Table("FacilityMortgage")]
    public partial class FacilityMortgage
    {
        public FacilityMortgage()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            FacilityMortgageFees = new HashSet<FacilityMortgageFee>();
        }

        [Key]
        public int FacilityMortgageId { get; set; }
        public int FacilityId { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FacilityMortgageInterestAmount { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FacilityTotalAssessedValue { get; set; }
        public int? RefFacilityMortgageInterestTypeId { get; set; }
        public int? RefFacilityMortgageTypeId { get; set; }
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
        [InverseProperty("FacilityMortgages")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityMortgages")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityMortgages")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilityMortgageInterestTypeId")]
        [InverseProperty("FacilityMortgages")]
        public virtual RefFacilityMortgageInterestType? RefFacilityMortgageInterestType { get; set; }
        [ForeignKey("RefFacilityMortgageTypeId")]
        [InverseProperty("FacilityMortgages")]
        public virtual RefFacilityMortgageType? RefFacilityMortgageType { get; set; }
        [InverseProperty("FacilityMortgage")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }
        [InverseProperty("FacilityMortgage")]
        public virtual ICollection<FacilityMortgageFee> FacilityMortgageFees { get; set; }
    }
}
