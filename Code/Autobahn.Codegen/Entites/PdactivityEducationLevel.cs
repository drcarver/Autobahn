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
    [Table("PDActivityEducationLevel")]
    public partial class PdactivityEducationLevel
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        [Column("PDActivityEducationLevelId")]
        public int PdactivityEducationLevelId { get; set; }
        /// <summary>
        /// Foreign key to ProfessionalDevelopmentActivity
        /// </summary>
        public int ProfessionalDevelopmentActivityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDActivityEducationLevelsAddressedId")]
        public int RefPdactivityEducationLevelsAddressedId { get; set; }
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
        [InverseProperty("PdactivityEducationLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ProfessionalDevelopmentActivityId")]
        [InverseProperty("PdactivityEducationLevels")]
        public virtual ProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PdactivityEducationLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
