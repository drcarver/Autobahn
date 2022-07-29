using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationFinancial")]
    public partial class OrganizationFinancial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationFinancial()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        public int OrganizationFinancialId { get; set; }

        public int FinancialAccountId { get; set; }

        public int OrganizationCalendarSessionId { get; set; }

        public decimal? ActualValue { get; set; }

        public decimal? BudgetedValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public decimal? EncumberedValue { get; set; }

        public decimal? Value { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FiscalPeriodBeginDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FiscalPeriodEndDate { get; set; }

        [StringLength(4)]
        public string FiscalYear { get; set; }

        public int? FinancialAccountProgramId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual FinancialAccount FinancialAccount { get; set; }

        public virtual FinancialAccountProgram FinancialAccountProgram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
