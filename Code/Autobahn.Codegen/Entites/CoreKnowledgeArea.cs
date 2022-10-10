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
    [Table("CoreKnowledgeArea", Schema = "Education.Common")]
    [Index("ProfessionalDevelopmentActivityId", "RefCoreKnowledgeAreaId", Name = "IX_CoreKnowledgeArea", IsUnique = true)]
    public partial class CoreKnowledgeArea
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int CoreKnowledgeAreaId { get; set; }
        /// <summary>
        /// Foreign key - RefProfessionalDevelopmentActivity
        /// </summary>
        public int ProfessionalDevelopmentActivityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefCoreKnowledgeAreaId { get; set; }
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
        [InverseProperty("CoreKnowledgeAreas")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ProfessionalDevelopmentActivityId")]
        [InverseProperty("CoreKnowledgeAreas")]
        public virtual StaffProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CoreKnowledgeAreas")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCoreKnowledgeAreaId")]
        [InverseProperty("CoreKnowledgeAreas")]
        public virtual RefCoreKnowledgeArea RefCoreKnowledgeArea { get; set; } = null!;
    }
}
