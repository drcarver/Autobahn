﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefBuildingEnvOrEnergyPerformanceRatingCat")]
    public partial class RefBuildingEnvOrEnergyPerformanceRatingCat
    {
        public RefBuildingEnvOrEnergyPerformanceRatingCat()
        {
            FacilityDesigns = new HashSet<FacilityDesign>();
        }

        /// <summary>
        /// The surrogate key for the options in this option set.
        /// </summary>
        [Key]
        public int RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }
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
        [InverseProperty("RefBuildingEnvOrEnergyPerformanceRatingCats")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefBuildingEnvOrEnergyPerformanceRatingCat")]
        public virtual ICollection<FacilityDesign> FacilityDesigns { get; set; }
    }
}
