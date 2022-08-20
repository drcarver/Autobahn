//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeed.cs
//**********************************************************using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonDigitalAccessSpeed", Schema = "Common")]
    public partial class PersonDigitalAccessSpeed : EntityBase
    {
        public decimal? InternetDownloadSpeed { get; set; }

        public DateTime? InternetSpeedTestDateTime { get; set; }

        public decimal? InternetUploadSpeed { get; set; }

        [ForeignKey("PersonDigitalAccess")]
        public Guid? PersonDigitalAccessId { get; set; }

        [ForeignKey("PersonLearningDevice")]
        public Guid? PersonLearningDeviceId { get; set; }

        public virtual PersonDigitalAccess PersonDigitalAccess { get; set; }

        public virtual PersonLearningDevice PersonLearningDevice { get; set; }
    }
}
