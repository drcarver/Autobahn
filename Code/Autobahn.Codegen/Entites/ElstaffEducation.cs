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
    [Table("ELStaffEducation", Schema = "EarlyLearning")]
    public partial class ELStaffEducation
    {
        [Key]
        public int ELStaffEducationId { get; set; }
        public int ELStaffId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ECDegreeOrCertificateHolder { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalCollegeCreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public decimal? TotalApprovedECCreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public decimal? SchoolAgeEducationPSCredits { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELLevelOfSpecializationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELProfessionalDevelopmentTopicAreaId { get; set; }
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
        public virtual ELStaff Elstaff { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEllevelOfSpecializationId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RefEllevelOfSpecialization? RefEllevelOfSpecialization { get; set; }
        [ForeignKey("RefElprofessionalDevelopmentTopicAreaId")]
        [InverseProperty("ElstaffEducations")]
        public virtual RefELProfessionalDevelopmentTopicArea? RefElprofessionalDevelopmentTopicArea { get; set; }
    }
}
