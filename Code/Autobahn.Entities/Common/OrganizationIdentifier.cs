using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationIdentifier", Schema = "Common")]
    public partial class OrganizationIdentifier
    {
        public Guid OrganizationIdentifierId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? RefOrganizationIdentificationSystemId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? RefOrganizationIdentifierTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationIdentificationSystem RefOrganizationIdentificationSystem { get; set; }

        public virtual RefOrganizationIdentifierType RefOrganizationIdentifierType { get; set; }
    }
}
