﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefEDFactsTeacherInexperiencedStatus")]
    public partial class RefEdfactsTeacherInexperiencedStatus
    {
        public RefEdfactsTeacherInexperiencedStatus()
        {
            K12staffAssignments = new HashSet<K12staffAssignment>();
        }

        [Key]
        [Column("RefEDFactsTeacherInexperiencedStatusId")]
        public int RefEdfactsTeacherInexperiencedStatusId { get; set; }
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
        [StringLength(4000)]
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefEdfactsTeacherInexperiencedStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefEdfactsTeacherInexperiencedStatus")]
        public virtual ICollection<K12staffAssignment> K12staffAssignments { get; set; }
    }
}
