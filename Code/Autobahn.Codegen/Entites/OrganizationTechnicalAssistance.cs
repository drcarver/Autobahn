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
    [Table("OrganizationTechnicalAssistance", Schema = "Organization")]
    public partial class OrganizationTechnicalAssistance
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int OrganizationTechnicalAssistanceId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
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
        [InverseProperty("OrganizationTechnicalAssistances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationTechnicalAssistances")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationTechnicalAssistances")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTechnicalAssistanceDeliveryTypeId")]
        [InverseProperty("OrganizationTechnicalAssistances")]
        public virtual RefTechnicalAssistanceDeliveryType? RefTechnicalAssistanceDeliveryType { get; set; }
        [ForeignKey("RefTechnicalAssistanceTypeId")]
        [InverseProperty("OrganizationTechnicalAssistances")]
        public virtual RefTechnicalAssistanceType? RefTechnicalAssistanceType { get; set; }
    }
}
