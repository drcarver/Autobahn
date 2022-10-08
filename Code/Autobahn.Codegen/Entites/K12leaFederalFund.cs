using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("K12LeaFederalFunds", Schema = "K12")]
    public partial class K12LeaFederalFunds
    {
        [Key]
        public int K12LeaFederalFundsId { get; set; }
        public int OrganizationCalendarSessionId { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? InnovativeProgramsFundsReceived { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? InnovativeDollarsSpent { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? PublicSchoolChoiceFundsSpent { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? SesFundsSpent { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? SesSchoolChoice20PercentObligation { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal? ParentalInvolvementReservationFunds { get; set; }
        public int? RefRlisProgramUseId { get; set; }
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
        [InverseProperty("K12leaFederalFunds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("K12leaFederalFunds")]
        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaFederalFunds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefRlisProgramUseId")]
        [InverseProperty("K12leaFederalFunds")]
        public virtual RefRlisProgramUse? RefRlisProgramUse { get; set; }
    }
}
