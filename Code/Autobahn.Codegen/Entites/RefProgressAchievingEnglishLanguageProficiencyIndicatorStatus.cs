using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus", Schema = "K12")]
    public partial class RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus
    {
        public RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus()
        {
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [InverseProperty("RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
    }
}
