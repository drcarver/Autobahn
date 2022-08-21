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
    [Table("OrganizationFinancial")]
    public partial class OrganizationFinancial
    {
        public OrganizationFinancial()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            Ipedsfinances = new HashSet<Ipedsfinance>();
        }

        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int OrganizationFinancialId { get; set; }
        /// <summary>
        /// Foreign key to FinancialAccount
        /// </summary>
        public int FinancialAccountId { get; set; }
        /// <summary>
        /// Foreign key to OrganizationCalendarSession
        /// </summary>
        public int OrganizationCalendarSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ActualValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(12, 1)")]
        public decimal? BudgetedValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? EncumberedValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Value { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? FiscalPeriodBeginDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? FiscalPeriodEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4)]
        public string? FiscalYear { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int? FinancialAccountProgramId { get; set; }
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
        [InverseProperty("OrganizationFinancials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FinancialAccountId")]
        [InverseProperty("OrganizationFinancials")]
        public virtual FinancialAccount FinancialAccount { get; set; } = null!;
        [ForeignKey("FinancialAccountProgramId")]
        [InverseProperty("OrganizationFinancials")]
        public virtual FinancialAccountProgram? FinancialAccountProgram { get; set; }
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("OrganizationFinancials")]
        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationFinancials")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("OrganizationFinancial")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }
        [InverseProperty("OrganizationFinancial")]
        public virtual ICollection<Ipedsfinance> Ipedsfinances { get; set; }
    }
}
