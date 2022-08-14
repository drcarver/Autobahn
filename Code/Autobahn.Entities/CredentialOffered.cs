using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialOffered")]
    public partial class CredentialOffered
    {
        public int CredentialOfferedId { get; set; }

        public int CredentialDefinitionId { get; set; }

        public int CredentialIssuerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CredentialOfferedStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CredentialOfferedEndDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }

        public virtual CredentialIssuer CredentialIssuer { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
