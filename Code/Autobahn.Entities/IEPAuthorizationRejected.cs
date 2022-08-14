using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IEPAuthorizationRejected")]
    public partial class IEPAuthorizationRejected
    {
        public int IEPAuthorizationRejectedId { get; set; }

        public int IEPAuthorizationId { get; set; }

        public string PortionDescription { get; set; }

        public string PortionExplanation { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IEPAuthorization IEPAuthorization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
