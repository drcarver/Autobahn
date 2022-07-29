using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityFinance")]
    public partial class FacilityFinance
    {
        public int FacilityFinanceId { get; set; }

        public int FacilityId { get; set; }

        public decimal? FacilityReplacementValue { get; set; }

        public decimal? IndebtednessAmountAllowed { get; set; }

        public decimal? InsuranceDeductible { get; set; }

        public decimal? PublicEducationMillRate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
