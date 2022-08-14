using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentAdministrationOrganization")]
    public partial class AssessmentAdministrationOrganization
    {
        public int AssessmentAdministrationOrganizationId { get; set; }

        public int AssessmentAdministrationId { get; set; }

        public int OrganizationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentAdministration AssessmentAdministration { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
