using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsPriceOfAttendance")]
    public partial class PsPriceOfAttendance
    {
        public int PSPriceOfAttendanceId { get; set; }

        public int PsInstitutionId { get; set; }

        [StringLength(7)]
        public string SessionDesignator { get; set; }

        public decimal? TuitionPublished { get; set; }

        public decimal? BoardCharges { get; set; }

        public decimal? RoomCharges { get; set; }

        public decimal? BooksAndSuppliesCosts { get; set; }

        public decimal? RequiredStudentFees { get; set; }

        public decimal? ComprehensiveFee { get; set; }

        public decimal? OtherStudentExpenses { get; set; }

        public decimal? PriceOfAttendance { get; set; }

        [StringLength(9)]
        public string IPEDSCollectionYearDesignator { get; set; }

        public int? RefTuitionUnitId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PsInstitution PsInstitution { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTuitionUnit RefTuitionUnit { get; set; }
    }
}
