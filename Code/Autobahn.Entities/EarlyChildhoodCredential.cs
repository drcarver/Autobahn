using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("EarlyChildhoodCredential")]
    public partial class EarlyChildhoodCredential
    {
        public int EarlyChildhoodCredentialId { get; set; }

        public int PersonCredentialId { get; set; }

        public int RefEarlyChildhoodCredentialId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonCredential PersonCredential { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEarlyChildhoodCredential RefEarlyChildhoodCredential { get; set; }
    }
}
