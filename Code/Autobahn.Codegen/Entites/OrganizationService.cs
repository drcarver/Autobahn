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
    [Table("OrganizationService", Schema = "Organization")]
    [Index("OrganizationId", "RefStudentSupportServiceTypeId", Name = "IX_Organization_RefStudentSupportServiceType", IsUnique = true)]
    public partial class OrganizationService
    {
        [Key]
        public int OrganizationServiceId { get; set; }
        public int OrganizationId { get; set; }
        public int RefStudentSupportServiceTypeId { get; set; }
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
        [InverseProperty("OrganizationServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationServices")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefStudentSupportServiceTypeId")]
        [InverseProperty("OrganizationServices")]
        public virtual RefStudentSupportServiceType RefStudentSupportServiceType { get; set; } = null!;
    }
}
