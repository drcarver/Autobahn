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
    [Table("ProfessionalDevelopmentSessionInstructor")]
    public partial class ProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int ProfessionalDevelopmentSessionInstructorId { get; set; }
        /// <summary>
        /// Foreign key to ProfessionalDevelopmentSession
        /// </summary>
        public int ProfessionalDevelopmentSessionId { get; set; }
        /// <summary>
        /// Foreign key to OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
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
        [InverseProperty("ProfessionalDevelopmentSessionInstructors")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ProfessionalDevelopmentSessionInstructors")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("ProfessionalDevelopmentSessionId")]
        [InverseProperty("ProfessionalDevelopmentSessionInstructors")]
        public virtual ProfessionalDevelopmentSession ProfessionalDevelopmentSession { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProfessionalDevelopmentSessionInstructors")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
