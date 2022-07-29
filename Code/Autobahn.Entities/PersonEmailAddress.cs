using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonEmailAddress")]
    public partial class PersonEmailAddress
    {
        public int PersonEmailAddressId { get; set; }

        public int PersonId { get; set; }

        [StringLength(128)]
        public string EmailAddress { get; set; }

        public int? RefEmailTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmailType RefEmailType { get; set; }
    }
}
