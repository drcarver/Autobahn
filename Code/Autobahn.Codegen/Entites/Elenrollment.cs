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
    [Table("ELEnrollment", Schema = "EarlyLearning")]
    public partial class ELEnrollment
    {
        [Key]
        public int ELEnrollmentId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? NumberOfDaysInAttendance { get; set; }
        /// <summary>
        /// Foreign key - ELClassSection.
        /// </summary>
        public int? ELClassSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIDEAEnvironmentELId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFoodServiceParticipationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefServiceOptionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELFederalFundingTypeId { get; set; }
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
        [InverseProperty("Elenrollments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ElclassSectionId")]
        [InverseProperty("Elenrollments")]
        public virtual ELClassSection? ElclassSection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("Elenrollments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Elenrollments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefElfederalFundingTypeId")]
        [InverseProperty("Elenrollments")]
        public virtual RefELFederalFundingType? RefElfederalFundingType { get; set; }
        [ForeignKey("RefFoodServiceParticipationId")]
        [InverseProperty("Elenrollments")]
        public virtual RefFoodServiceParticipation? RefFoodServiceParticipation { get; set; }
        [ForeignKey("RefIdeaenvironmentElid")]
        [InverseProperty("Elenrollments")]
        public virtual RefIDEAEnvironmentEL? RefIdeaenvironmentEl { get; set; }
        [ForeignKey("RefServiceOptionId")]
        [InverseProperty("Elenrollments")]
        public virtual RefServiceOption? RefServiceOption { get; set; }
    }
}
