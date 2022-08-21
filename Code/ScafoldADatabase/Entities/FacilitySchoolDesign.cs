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
    [Table("FacilitySchoolDesign")]
    [Index("FacilityDesignId", "RefBuildingSchoolDesignTypeId", Name = "IX_FacilityDesign_RefBuildingSchoolDesignType", IsUnique = true)]
    public partial class FacilitySchoolDesign
    {
        [Key]
        public int FacilitySchoolDesignId { get; set; }
        public int FacilityDesignId { get; set; }
        public int RefBuildingSchoolDesignTypeId { get; set; }
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
        [InverseProperty("FacilitySchoolDesigns")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityDesignId")]
        [InverseProperty("FacilitySchoolDesigns")]
        public virtual FacilityDesign FacilityDesign { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilitySchoolDesigns")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingSchoolDesignTypeId")]
        [InverseProperty("FacilitySchoolDesigns")]
        public virtual RefBuildingSchoolDesignType RefBuildingSchoolDesignType { get; set; } = null!;
    }
}
