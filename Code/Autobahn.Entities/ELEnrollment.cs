using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELEnrollment")]
    public partial class ELEnrollment
    {
        public int ELEnrollmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }

        public decimal? NumberOfDaysInAttendance { get; set; }

        public int? ELClassSectionId { get; set; }

        public int? RefIDEAEnvironmentELId { get; set; }

        public int? RefFoodServiceParticipationId { get; set; }

        public int? RefServiceOptionId { get; set; }

        public int? RefELFederalFundingTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ELClassSection ELClassSection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELFederalFundingType RefELFederalFundingType { get; set; }

        public virtual RefFoodServiceParticipation RefFoodServiceParticipation { get; set; }

        public virtual RefIDEAEnvironmentEL RefIDEAEnvironmentEL { get; set; }

        public virtual RefServiceOption RefServiceOption { get; set; }
    }
}
