using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12LeaFederalFunds
    {
        public int K12LeaFederalFundsId { get; set; }

        public int OrganizationCalendarSessionId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InnovativeProgramsFundsReceived { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InnovativeDollarsSpent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PublicSchoolChoiceFundsSpent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SesFundsSpent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SesSchoolChoice20PercentObligation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentalInvolvementReservationFunds { get; set; }

        public int? RefRlisProgramUseId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefRlisProgramUse RefRlisProgramUse { get; set; }
    }
}
