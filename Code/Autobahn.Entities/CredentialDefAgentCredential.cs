using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefAgentCredential")]
    public partial class CredentialDefAgentCredential
    {
        public int CredentialDefAgentCredentialId { get; set; }

        public int CredentialDefinitionId { get; set; }

        public int CredentialDefAgentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CredentialDefAgent CredentialDefAgent { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }
    }
}
