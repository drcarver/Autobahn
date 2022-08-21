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
    [Table("RefHighSchoolDiplomaType")]
    public partial class RefHighSchoolDiplomaType
    {
        public RefHighSchoolDiplomaType()
        {
            AeStudentAcademicRecords = new HashSet<AeStudentAcademicRecord>();
            K12studentAcademicRecords = new HashSet<K12studentAcademicRecord>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefHighSchoolDiplomaTypeId { get; set; }
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
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefHighSchoolDiplomaTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefHighSchoolDiplomaType")]
        public virtual ICollection<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }
        [InverseProperty("RefHighSchoolDiplomaType")]
        public virtual ICollection<K12studentAcademicRecord> K12studentAcademicRecords { get; set; }
    }
}
