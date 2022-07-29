using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CteStudentAcademicRecord")]
    public partial class CteStudentAcademicRecord
    {
        public int CteStudentAcademicRecordId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? CreditsAttemptedCumulative { get; set; }

        public decimal? CreditsEarnedCumulative { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        public int? RefProfessionalTechnicalCredentialTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefProfessionalTechnicalCredentialType RefProfessionalTechnicalCredentialType { get; set; }
    }
}
