using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationAccreditation")]
    public partial class OrganizationAccreditation
    {
        public int OrganizationAccreditationId { get; set; }

        public int OrganizationId { get; set; }

        public bool? AccreditationStatus { get; set; }

        public int? RefAccreditationAgencyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AccreditationAwardDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AccreditationExpirationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SeekingAccreditationDate { get; set; }

        public int? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [StringLength(300)]
        public string AccreditationAgencyName { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAccreditationAgency RefAccreditationAgency { get; set; }

        public virtual RefHigherEducationInstitutionAccreditationStatu RefHigherEducationInstitutionAccreditationStatu { get; set; }
    }
}
