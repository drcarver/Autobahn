//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTelephone.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationTelephone")]
    public partial class OrganizationTelephone : EntityBase
    {
        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(24)]
        public string TelephoneNumber { get; set; }

        public bool PrimaryTelephoneNumberIndicator { get; set; }

        [ForeignKey("RefInstitutionTelephoneType")]
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        [ForeignKey("RefTelephoneNumberListedStatus")]
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefInstitutionTelephoneType RefInstitutionTelephoneType { get; set; }

        public virtual RefTelephoneNumberListedStatus RefTelephoneNumberListedStatus { get; set; }
    }
}
