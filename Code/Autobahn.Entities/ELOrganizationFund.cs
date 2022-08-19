using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELOrganizationFund")]
    public partial class ELOrganizationFund
    {
        [Key]
        public int ELOrganizationFundsId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? RefELFederalFundingTypeId { get; set; }

        public int? RefELLocalRevenueSourceId { get; set; }

        public int? RefELOtherFederalFundingSourcesId { get; set; }

        public int? RefELStateRevenueSourceId { get; set; }

        public int? RefBillableBasisTypeId { get; set; }

        public int? RefReimbursementTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBillableBasisType RefBillableBasisType { get; set; }

        public virtual RefELFederalFundingType RefELFederalFundingType { get; set; }

        public virtual RefELLocalRevenueSource RefELLocalRevenueSource { get; set; }

        public virtual RefELOtherFederalFundingSource RefELOtherFederalFundingSource { get; set; }

        public virtual RefELStateRevenueSource RefELStateRevenueSource { get; set; }

        public virtual RefReimbursementType RefReimbursementType { get; set; }
    }
}
