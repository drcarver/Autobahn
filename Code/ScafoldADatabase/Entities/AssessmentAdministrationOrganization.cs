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
    [Table("AssessmentAdministration_Organization")]
    [Index("AssessmentAdministrationId", "OrganizationId", Name = "IX_AssessmentAdministration_Organization", IsUnique = true)]
    public partial class AssessmentAdministrationOrganization
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("AssessmentAdministration_OrganizationId")]
        public int AssessmentAdministrationOrganizationId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentAdministration
        /// </summary>
        public int AssessmentAdministrationId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
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

        [ForeignKey("AssessmentAdministrationId")]
        [InverseProperty("AssessmentAdministrationOrganizations")]
        public virtual AssessmentAdministration AssessmentAdministration { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentAdministrationOrganizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("AssessmentAdministrationOrganizations")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentAdministrationOrganizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
