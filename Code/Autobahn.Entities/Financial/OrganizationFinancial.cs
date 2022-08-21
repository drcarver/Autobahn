//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   OrganizationFinancial.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;
using Autobahn.Entities.Facility;
using Autobahn.Interfaces.Financial;

namespace Autobahn.Entities.Financial
{
    [Table("OrganizationFinancial", Schema = "Financial")]
    public partial class OrganizationFinancial : EntityBase, IOrganizationFinancial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationFinancial()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [ForeignKey("FinancialAccount")]
        public Guid FinancialAccountId { get; set; }

        [ForeignKey("OrganizationCalendarSession")]
        public Guid OrganizationCalendarSessionId { get; set; }

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

        [ForeignKey("FinancialAccountProgram")]
        public Guid? FinancialAccountProgramId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual FinancialAccount FinancialAccount { get; set; }

        public virtual FinancialAccountProgram FinancialAccountProgram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }
    }
}
