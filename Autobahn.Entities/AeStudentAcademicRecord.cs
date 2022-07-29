using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AeStudentAcademicRecord")]
    public partial class AeStudentAcademicRecord
    {
        public int AeStudentAcademicRecordId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        public int? RefHighSchoolDiplomaTypeId { get; set; }

        public int? RefProfessionalTechnicalCredentialTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefHighSchoolDiplomaType RefHighSchoolDiplomaType { get; set; }

        public virtual RefProfessionalTechnicalCredentialType RefProfessionalTechnicalCredentialType { get; set; }
    }
}
