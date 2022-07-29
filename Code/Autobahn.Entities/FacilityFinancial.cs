using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityFinancial")]
    public partial class FacilityFinancial
    {
        public int FacilityFinancialId { get; set; }

        public int OrganizationFinancialId { get; set; }

        public int? FacilityLeaseId { get; set; }

        public int? FacilityMortgageId { get; set; }

        public int? FacilityMortgageFeeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual FacilityLease FacilityLease { get; set; }

        public virtual FacilityMortgage FacilityMortgage { get; set; }

        public virtual FacilityMortgageFee FacilityMortgageFee { get; set; }

        public virtual OrganizationFinancial OrganizationFinancial { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
