using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Authentication")]
    public partial class Authentication
    {
        public int AuthenticationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(60)]
        public string IdentityProviderName { get; set; }

        [StringLength(512)]
        public string IdentityProviderUri { get; set; }

        [StringLength(40)]
        public string LoginIdentifier { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
