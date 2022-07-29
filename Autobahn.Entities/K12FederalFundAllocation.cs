using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12FederalFundAllocation
    {
        public int K12FederalFundAllocationId { get; set; }

        public int OrganizationCalendarSessionId { get; set; }

        [Required]
        [StringLength(10)]
        public string FederalProgramCode { get; set; }

        public int? RefFederalProgramFundingAllocationTypeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FederalProgramsFundingAllocation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FundsTransferAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SchoolImprovementAllocation { get; set; }

        public bool? LeaTransferabilityOfFunds { get; set; }

        public int? RefLeaFundsTransferTypeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SchoolImprovementReservedPercent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SesPerPupilExpenditure { get; set; }

        public int? NumberOfImmigrantProgramSubgrants { get; set; }

        public int? RefReapAlternativeFundingStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual RefReapAlternativeFundingStatu RefReapAlternativeFundingStatu { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFederalProgramFundingAllocationType RefFederalProgramFundingAllocationType { get; set; }

        public virtual RefLeaFundsTransferType RefLeaFundsTransferType { get; set; }
    }
}
