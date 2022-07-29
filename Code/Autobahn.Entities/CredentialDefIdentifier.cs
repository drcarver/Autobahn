using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefIdentifier")]
    public partial class CredentialDefIdentifier
    {
        public int CredentialDefIdentifierId { get; set; }

        public int CredentialDefinitionId { get; set; }

        [StringLength(512)]
        public string Identifier { get; set; }

        public int? RefCredentialIdentifierSystemId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCredentialIdentifierSystem RefCredentialIdentifierSystem { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }
    }
}
