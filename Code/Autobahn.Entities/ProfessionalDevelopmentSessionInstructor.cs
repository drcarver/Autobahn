using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProfessionalDevelopmentSessionInstructor")]
    public partial class ProfessionalDevelopmentSessionInstructor
    {
        public int ProfessionalDevelopmentSessionInstructorId { get; set; }

        public int ProfessionalDevelopmentSessionId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual ProfessionalDevelopmentSession ProfessionalDevelopmentSession { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
