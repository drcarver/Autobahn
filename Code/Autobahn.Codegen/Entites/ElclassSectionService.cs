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
    [Table("ELClassSectionService")]
    public partial class ElclassSectionService
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("ELClassSectionServiceId")]
        public int ElclassSectionServiceId { get; set; }
        [Column("ELClassSectionId")]
        public int ElclassSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? YoungestAgeServed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? OldestAgeServed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ServesChildrenWithSpecialNeeds { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("ELClassGroupCurriculumType")]
        [StringLength(60)]
        public string? ElclassGroupCurriculumType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELGroupSizeStandardMetId")]
        public int? RefElgroupSizeStandardMetId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFrequencyOfServiceId { get; set; }
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
        [InverseProperty("ElclassSectionServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ElclassSectionId")]
        [InverseProperty("ElclassSectionServices")]
        public virtual ElclassSection ElclassSection { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElclassSectionServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefElgroupSizeStandardMetId")]
        [InverseProperty("ElclassSectionServices")]
        public virtual RefElgroupSizeStandardMet? RefElgroupSizeStandardMet { get; set; }
        [ForeignKey("RefFrequencyOfServiceId")]
        [InverseProperty("ElclassSectionServices")]
        public virtual RefFrequencyOfService? RefFrequencyOfService { get; set; }
    }
}
