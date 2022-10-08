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
    [Table("FacilityJointUse", Schema = "Facilities")]
    public partial class FacilityJointUse
    {
        [Key]
        public int FacilityJointUseId { get; set; }
        public int FacilityId { get; set; }
        public int? RefBuildingJointUseRationaleTypeId { get; set; }
        public int? RefBuildingJointUserTypeId { get; set; }
        public int? RefBuildingJointUseSchedulingTypeId { get; set; }
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
        [InverseProperty("FacilityJointUses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityJointUses")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityJointUses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingJointUseRationaleTypeId")]
        [InverseProperty("FacilityJointUses")]
        public virtual RefBuildingJointUseRationaleType? RefBuildingJointUseRationaleType { get; set; }
        [ForeignKey("RefBuildingJointUseSchedulingTypeId")]
        [InverseProperty("FacilityJointUses")]
        public virtual RefBuildingJointUseSchedulingType? RefBuildingJointUseSchedulingType { get; set; }
        [ForeignKey("RefBuildingJointUserTypeId")]
        [InverseProperty("FacilityJointUses")]
        public virtual RefBuildingJointUserType? RefBuildingJointUserType { get; set; }
    }
}
