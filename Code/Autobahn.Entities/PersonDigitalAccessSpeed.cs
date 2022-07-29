using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDigitalAccessSpeed")]
    public partial class PersonDigitalAccessSpeed
    {
        public int PersonDigitalAccessSpeedId { get; set; }

        public decimal? InternetDownloadSpeed { get; set; }

        public DateTime? InternetSpeedTestDateTime { get; set; }

        public decimal? InternetUploadSpeed { get; set; }

        public int? PersonDigitalAccessId { get; set; }

        public int? PersonLearningDeviceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonDigitalAccess PersonDigitalAccess { get; set; }

        public virtual PersonLearningDevice PersonLearningDevice { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
