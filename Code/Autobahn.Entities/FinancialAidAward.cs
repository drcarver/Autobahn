using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FinancialAidAward")]
    public partial class FinancialAidAward
    {
        public int FinancialAidAwardId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefFinancialAidAwardTypeId { get; set; }

        public int? RefFinancialAidStatusId { get; set; }

        public decimal? FinancialAidAwardAmount { get; set; }

        [StringLength(9)]
        public string FinancialAidYearDesignator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFinancialAidAwardStatu RefFinancialAidAwardStatu { get; set; }

        public virtual RefFinancialAidAwardType RefFinancialAidAwardType { get; set; }
    }
}
