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
    [Table("ELOrganizationFunds", Schema = "EarlyLearning")]
    public partial class ELOrganizationFunds
    {
        [Key]
        public int ELOrganizationFundsId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELFederalFundingTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELLocalRevenueSourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELOtherFederalFundingSourcesId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELStateRevenueSourceId { get; set; }
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
        public virtual RefELFederalFundingType? RefElfederalFundingType { get; set; }
        [ForeignKey("RefEllocalRevenueSourceId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefELLocalRevenueSource? RefEllocalRevenueSource { get; set; }
        [ForeignKey("RefElotherFederalFundingSourcesId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefELOtherFederalFundingSources? RefElotherFederalFundingSources { get; set; }
        [ForeignKey("RefElstateRevenueSourceId")]
        [InverseProperty("ElorganizationFunds")]
        public virtual RefELStateRevenueSource? RefElstateRevenueSource { get; set; }
        [ForeignKey("RefReimbursementTypeId")]
        [InverseProperty("ELOrganizationFunds")]
        public virtual RefReimbursementType? RefReimbursementType { get; set; }
    }
}
