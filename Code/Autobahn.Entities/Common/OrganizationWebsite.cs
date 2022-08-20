//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationWebsite.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationWebsite")]
    public partial class OrganizationWebsite : EntityBase
    {
        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        [StringLength(300)]
        public string Website { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
