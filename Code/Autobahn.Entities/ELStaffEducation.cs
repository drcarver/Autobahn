using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELStaffEducation")]
    public partial class ELStaffEducation
    {
        public int ELStaffEducationId { get; set; }

        public int ELStaffId { get; set; }

        public bool? ECDegreeOrCertificateHolder { get; set; }

        public decimal? TotalCollegeCreditsEarned { get; set; }

        public decimal? TotalApprovedECCreditsEarned { get; set; }

        public decimal? SchoolAgeEducationPSCredits { get; set; }

        public int? RefELLevelOfSpecializationId { get; set; }

        public int? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ELStaff ELStaff { get; set; }

        public virtual RefELLevelOfSpecialization RefELLevelOfSpecialization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELProfessionalDevelopmentTopicArea RefELProfessionalDevelopmentTopicArea { get; set; }
    }
}
