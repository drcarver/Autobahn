using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffCredential")]
    public partial class StaffCredential
    {
        public int StaffCredentialId { get; set; }

        public int PersonCredentialId { get; set; }

        public bool? TechnologySkillsStandardsMet { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        public bool? CTEInstructorIndustryCertification { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CardiopulmonaryResuscitationCertification { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FirstAidCertification { get; set; }

        public int? RefTeachingCredentialTypeId { get; set; }

        public int? RefTeachingCredentialBasisId { get; set; }

        public int? RefChildDevAssociateTypeId { get; set; }

        public int? RefParaprofessionalQualificationId { get; set; }

        public int? RefProgramSponsorTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefAeCertificationTypeId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonCredential PersonCredential { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAeCertificationType RefAeCertificationType { get; set; }

        public virtual RefChildDevelopmentAssociateType RefChildDevelopmentAssociateType { get; set; }

        public virtual RefParaprofessionalQualification RefParaprofessionalQualification { get; set; }

        public virtual RefProgramSponsorType RefProgramSponsorType { get; set; }

        public virtual RefTeachingCredentialBasis RefTeachingCredentialBasis { get; set; }

        public virtual RefTeachingCredentialType RefTeachingCredentialType { get; set; }
    }
}
