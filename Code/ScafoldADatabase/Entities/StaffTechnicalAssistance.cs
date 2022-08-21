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
    [Table("StaffTechnicalAssistance")]
    public partial class StaffTechnicalAssistance
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int StaffTechnicalAssistanceId { get; set; }
        /// <summary>
        /// Surrogate key from Organization Person Role
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTechnicalAssistanceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTechnicalAssistanceDeliveryTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? TechnicalAssistanceApprovedInd { get; set; }
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
        [InverseProperty("StaffTechnicalAssistances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("StaffTechnicalAssistances")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("StaffTechnicalAssistances")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTechnicalAssistanceDeliveryTypeId")]
        [InverseProperty("StaffTechnicalAssistances")]
        public virtual RefTechnicalAssistanceDeliveryType? RefTechnicalAssistanceDeliveryType { get; set; }
        [ForeignKey("RefTechnicalAssistanceTypeId")]
        [InverseProperty("StaffTechnicalAssistances")]
        public virtual RefTechnicalAssistanceType? RefTechnicalAssistanceType { get; set; }
    }
}
