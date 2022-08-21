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
    [Table("FacilityMandate")]
    public partial class FacilityMandate
    {
        public FacilityMandate()
        {
            FacilityCompliances = new HashSet<FacilityCompliance>();
        }

        [Key]
        public int FacilityMandateId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(60)]
        public string? FacilityStateOrLocalMandateName { get; set; }
        public int? RefFacilitiesMandateAuthorityTypeId { get; set; }
        public int? RefFacilityApplicableFederalMandateTypeId { get; set; }
        public int? RefFacilityFederalMandateInterestTypeId { get; set; }
        public int? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }
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
        [InverseProperty("FacilityMandates")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityMandates")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityMandates")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFacilitiesMandateAuthorityTypeId")]
        [InverseProperty("FacilityMandates")]
        public virtual RefFacilitiesMandateAuthorityType? RefFacilitiesMandateAuthorityType { get; set; }
        [ForeignKey("RefFacilityApplicableFederalMandateTypeId")]
        [InverseProperty("FacilityMandates")]
        public virtual RefFacilityApplicableFederalMandateType? RefFacilityApplicableFederalMandateType { get; set; }
        [ForeignKey("RefFacilityFederalMandateInterestTypeId")]
        [InverseProperty("FacilityMandates")]
        public virtual RefFacilityFederalMandateInterestType? RefFacilityFederalMandateInterestType { get; set; }
        [ForeignKey("RefFacilityStateOrLocalMandateInterestTypeId")]
        [InverseProperty("FacilityMandates")]
        public virtual RefFacilityStateOrLocalMandateInterestType? RefFacilityStateOrLocalMandateInterestType { get; set; }
        [InverseProperty("FacilityMandate")]
        public virtual ICollection<FacilityCompliance> FacilityCompliances { get; set; }
    }
}
