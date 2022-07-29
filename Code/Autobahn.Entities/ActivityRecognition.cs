using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ActivityRecognition")]
    public partial class ActivityRecognition
    {
        public int ActivityRecognitionId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int RefActivityRecognitionTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefActivityRecognitionType RefActivityRecognitionType { get; set; }
    }
}
