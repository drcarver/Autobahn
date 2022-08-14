using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonHealth")]
    public partial class PersonHealth
    {
        public int PersonHealthId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VisionScreeningDate { get; set; }

        public int? RefVisionScreeningStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HearingScreeningDate { get; set; }

        public int? RefHearingScreeningStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DentalScreeningDate { get; set; }

        public int? RefDentalScreeningStatusId { get; set; }

        public int? RefHealthInsuranceCoverageId { get; set; }

        public int? RefDentalInsuranceCoverageTypeId { get; set; }

        public int? RefMedicalAlertIndicatorId { get; set; }

        [StringLength(300)]
        public string HealthScreeningEquipmentUsed { get; set; }

        public string HealthScreeningFollowUpRecommendation { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefDentalInsuranceCoverageType RefDentalInsuranceCoverageType { get; set; }

        public virtual RefDentalScreeningStatus RefDentalScreeningStatus { get; set; }

        public virtual RefHealthInsuranceCoverage RefHealthInsuranceCoverage { get; set; }

        public virtual RefHearingScreeningStatus RefHearingScreeningStatus { get; set; }

        public virtual RefMedicalAlertIndicator RefMedicalAlertIndicator { get; set; }

        public virtual RefVisionScreeningStatus RefVisionScreeningStatus { get; set; }
    }
}
