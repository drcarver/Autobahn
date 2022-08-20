//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCredential.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("StaffCredential", Schema = "Common")]
    public partial class StaffCredential : EntityBase
    {
        public bool? TechnologySkillsStandardsMet { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        public bool? CTEInstructorIndustryCertification { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CardiopulmonaryResuscitationCertification { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FirstAidCertification { get; set; }

        [ForeignKey("RefTeachingCredentialType")]
        public Guid? RefTeachingCredentialTypeId { get; set; }

        [ForeignKey("RefTeachingCredentialBasis")]
        public Guid? RefTeachingCredentialBasisId { get; set; }

        [ForeignKey("RefChildDevAssociateType")]
        public Guid? RefChildDevAssociateTypeId { get; set; }

        [ForeignKey("RefParaprofessionalQualification")]
        public Guid? RefParaprofessionalQualificationId { get; set; }

        [ForeignKey("RefProgramSponsorType")]
        public Guid? RefProgramSponsorTypeId { get; set; }

        [ForeignKey("RefAeCertificationType")]
        public Guid? RefAeCertificationTypeId { get; set; }

        public virtual PersonCredential PersonCredential { get; set; }

        public virtual RefAeCertificationType RefAeCertificationType { get; set; }

        public virtual RefChildDevelopmentAssociateType RefChildDevelopmentAssociateType { get; set; }

        public virtual RefParaprofessionalQualification RefParaprofessionalQualification { get; set; }

        public virtual RefProgramSponsorType RefProgramSponsorType { get; set; }

        public virtual RefTeachingCredentialBasis RefTeachingCredentialBasis { get; set; }

        public virtual RefTeachingCredentialType RefTeachingCredentialType { get; set; }
    }
}
