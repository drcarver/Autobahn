﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefFacilityCapitalProgramMgmtType", Schema = "Facilities")]
    public partial class RefFacilityCapitalProgramMgmtType
    {
        public RefFacilityCapitalProgramMgmtType()
        {
            FacilityManagements = new HashSet<FacilityManagement>();
        }

        /// <summary>
        /// The surrogate key for the options in this option set.
        /// </summary>
        [Key]
        public int RefFacilityCapitalProgramMgmtTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(60)]
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
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefFacilityCapitalProgramMgmtTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefFacilityCapitalProgramMgmtType")]
        public virtual ICollection<FacilityManagement> FacilityManagements { get; set; }
    }
}
