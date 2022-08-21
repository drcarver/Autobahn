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
    [Table("K12FederalFundAllocation")]
    public partial class K12federalFundAllocation
    {
        [Key]
        [Column("K12FederalFundAllocationId")]
        public int K12federalFundAllocationId { get; set; }
        public int OrganizationCalendarSessionId { get; set; }
        [StringLength(10)]
        public string FederalProgramCode { get; set; } = null!;
        public int? RefFederalProgramFundingAllocationTypeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? FederalProgramsFundingAllocation { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? FundsTransferAmount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? SchoolImprovementAllocation { get; set; }
        public bool? LeaTransferabilityOfFunds { get; set; }
        public int? RefLeaFundsTransferTypeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? SchoolImprovementReservedPercent { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? SesPerPupilExpenditure { get; set; }
        public int? NumberOfImmigrantProgramSubgrants { get; set; }
        public int? RefReapAlternativeFundingStatusId { get; set; }
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
        [InverseProperty("K12federalFundAllocations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("K12federalFundAllocations")]
        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12federalFundAllocations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFederalProgramFundingAllocationTypeId")]
        [InverseProperty("K12federalFundAllocations")]
        public virtual RefFederalProgramFundingAllocationType? RefFederalProgramFundingAllocationType { get; set; }
        [ForeignKey("RefLeaFundsTransferTypeId")]
        [InverseProperty("K12federalFundAllocations")]
        public virtual RefLeaFundsTransferType? RefLeaFundsTransferType { get; set; }
        [ForeignKey("RefReapAlternativeFundingStatusId")]
        [InverseProperty("K12federalFundAllocations")]
        public virtual RefReapAlternativeFundingStatus? RefReapAlternativeFundingStatus { get; set; }
    }
}
