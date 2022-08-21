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
    [Table("EarlyChildhoodProgramTypeOffered")]
    [Index("OrganizationId", "RefEarlyChildhoodProgramEnrollmentTypeId", Name = "IX_EarlyChildhoodProgramTypeOffered", IsUnique = true)]
    public partial class EarlyChildhoodProgramTypeOffered
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int EarlyChildhoodProgramTypeOfferedId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? InclusiveSettingIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCommunityBasedTypeId { get; set; }
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
        [InverseProperty("EarlyChildhoodProgramTypeOffereds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("EarlyChildhoodProgramTypeOffereds")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("EarlyChildhoodProgramTypeOffereds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCommunityBasedTypeId")]
        [InverseProperty("EarlyChildhoodProgramTypeOffereds")]
        public virtual RefCommunityBasedType? RefCommunityBasedType { get; set; }
        [ForeignKey("RefEarlyChildhoodProgramEnrollmentTypeId")]
        [InverseProperty("EarlyChildhoodProgramTypeOffereds")]
        public virtual RefEarlyChildhoodProgramEnrollmentType RefEarlyChildhoodProgramEnrollmentType { get; set; } = null!;
    }
}
