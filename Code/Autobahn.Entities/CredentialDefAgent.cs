using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefAgent")]
    public partial class CredentialDefAgent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialDefAgent()
        {
            CredentialDefAgentCredentials = new HashSet<CredentialDefAgentCredential>();
        }

        public int CredentialDefAgentId { get; set; }

        public Guid? OrganizationId { get; set; }

        public int? PersonId { get; set; }

        public int? RefCTDLOrganizationTypeId { get; set; }

        public int? RefCredentialDefAgentRoleTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCredentialDefAgentRoleType RefCredentialDefAgentRoleType { get; set; }

        public virtual RefCTDLOrganizationType RefCTDLOrganizationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }
    }
}
