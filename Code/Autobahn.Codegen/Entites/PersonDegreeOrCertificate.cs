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
    [Table("PersonDegreeOrCertificate")]
    public partial class PersonDegreeOrCertificate
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonDegreeOrCertificateId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(45)]
        public string? DegreeOrCertificateTitleOrSubject { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDegreeOrCertificateTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AwardDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? NameOfInstitution { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHigherEducationInstitutionAccreditationStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEducationVerificationMethodId { get; set; }
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
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefDegreeOrCertificateTypeId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual RefDegreeOrCertificateType? RefDegreeOrCertificateType { get; set; }
        [ForeignKey("RefEducationVerificationMethodId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual RefEducationVerificationMethod? RefEducationVerificationMethod { get; set; }
        [ForeignKey("RefHigherEducationInstitutionAccreditationStatusId")]
        [InverseProperty("PersonDegreeOrCertificates")]
        public virtual RefHigherEducationInstitutionAccreditationStatus? RefHigherEducationInstitutionAccreditationStatus { get; set; }
    }
}
