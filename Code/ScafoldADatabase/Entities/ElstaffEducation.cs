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
    [Table("ELStaffEducation")]
    public partial class ElstaffEducation
    {
        [Key]
        [Column("ELStaffEducationId")]
        public int ElstaffEducationId { get; set; }
        [Column("ELStaffId")]
        public int ElstaffId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("ECDegreeOrCertificateHolder")]
        public bool? EcdegreeOrCertificateHolder { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalCollegeCreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("TotalApprovedECCreditsEarned", TypeName = "decimal(10, 2)")]
        public decimal? TotalApprovedEccreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("SchoolAgeEducationPSCredits", TypeName = "decimal(10, 2)")]
        public decimal? SchoolAgeEducationPscredits { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELLevelOfSpecializationId")]
        public int? RefEllevelOfSpecializationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELProfessionalDevelopmentTopicAreaId")]
        public int? RefElprofessionalDevelopmentTopicAreaId { get; set; }
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
        [InverseProperty("ElstaffEducations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ElstaffId")]
        [InverseProperty("ElstaffEducations")]
        public virtual Elstaff Elstaff { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEllevelOfSpecializationId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RefEllevelOfSpecialization? RefEllevelOfSpecialization { get; set; }
        [ForeignKey("RefElprofessionalDevelopmentTopicAreaId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RefElprofessionalDevelopmentTopicArea? RefElprofessionalDevelopmentTopicArea { get; set; }
    }
}
