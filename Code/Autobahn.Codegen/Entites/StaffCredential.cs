using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("StaffCredential")]
    public partial class StaffCredential
    {
        [Key]
        public int StaffCredentialId { get; set; }
        public int PersonCredentialId { get; set; }
        public bool? TechnologySkillsStandardsMet { get; set; }
        [StringLength(7)]
        public string? DiplomaOrCredentialAwardDate { get; set; }
        [Column("CTEInstructorIndustryCertification")]
        public bool? CteinstructorIndustryCertification { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CardiopulmonaryResuscitationCertification { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FirstAidCertification { get; set; }
        public int? RefTeachingCredentialTypeId { get; set; }
        public int? RefTeachingCredentialBasisId { get; set; }
        public int? RefChildDevAssociateTypeId { get; set; }
        public int? RefParaprofessionalQualificationId { get; set; }
        public int? RefProgramSponsorTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAeCertificationTypeId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("StaffCredentials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonCredentialId")]
        [InverseProperty("StaffCredentials")]
        public virtual PersonCredential PersonCredential { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("StaffCredentials")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAeCertificationTypeId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefAeCertificationType? RefAeCertificationType { get; set; }
        [ForeignKey("RefChildDevAssociateTypeId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefChildDevelopmentAssociateType? RefChildDevAssociateType { get; set; }
        [ForeignKey("RefParaprofessionalQualificationId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefParaprofessionalQualification? RefParaprofessionalQualification { get; set; }
        [ForeignKey("RefProgramSponsorTypeId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefProgramSponsorType? RefProgramSponsorType { get; set; }
        [ForeignKey("RefTeachingCredentialBasisId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefTeachingCredentialBasis? RefTeachingCredentialBasis { get; set; }
        [ForeignKey("RefTeachingCredentialTypeId")]
        [InverseProperty("StaffCredentials")]
        public virtual RefTeachingCredentialType? RefTeachingCredentialType { get; set; }
    }
}
