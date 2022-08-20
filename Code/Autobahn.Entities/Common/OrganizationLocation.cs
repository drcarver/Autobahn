//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationLocation.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationLocation", Schema = "Common")]
    public partial class OrganizationLocation : EntityBase
    {
        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        [ForeignKey("Location")]
        public Guid LocationId { get; set; }

        public Guid? RefOrganizationLocationTypeId { get; set; }

        public virtual Location Location { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefOrganizationLocationType RefOrganizationLocationType { get; set; }
    }
}
