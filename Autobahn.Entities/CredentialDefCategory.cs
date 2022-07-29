using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefCategory")]
    public partial class CredentialDefCategory
    {
        public int CredentialDefCategoryId { get; set; }

        public int CredentialDefinitionId { get; set; }

        [StringLength(60)]
        public string Category { get; set; }

        [StringLength(30)]
        public string CategorySystem { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }
    }
}
