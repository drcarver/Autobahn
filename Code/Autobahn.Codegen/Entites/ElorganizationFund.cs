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
    [Table("ELOrganizationFunds")]
    public partial class ElorganizationFund
    {
        [Key]
        [Column("ELOrganizationFundsId")]
        public int ElorganizationFundsId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELFederalFundingTypeId")]
        public int? RefElfederalFundingTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELLocalRevenueSourceId")]
        public int? RefEllocalRevenueSourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELOtherFederalFundingSourcesId")]
        public int? RefElotherFederalFundingSourcesId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELStateRevenueSourceId")]
        public int? RefElstateRevenueSourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBillableBasisTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefReimbursementTypeId { get; set; }
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
        [InverseProperty("ElorganizationFunds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBillableBasisTypeId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefBillableBasisType? RefBillableBasisType { get; set; }
        [ForeignKey("RefElfederalFundingTypeId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefElfederalFundingType? RefElfederalFundingType { get; set; }
        [ForeignKey("RefEllocalRevenueSourceId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefEllocalRevenueSource? RefEllocalRevenueSource { get; set; }
        [ForeignKey("RefElotherFederalFundingSourcesId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefElotherFederalFundingSource? RefElotherFederalFundingSources { get; set; }
        [ForeignKey("RefElstateRevenueSourceId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefElstateRevenueSource? RefElstateRevenueSource { get; set; }
        [ForeignKey("RefReimbursementTypeId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefReimbursementType? RefReimbursementType { get; set; }
    }
}
