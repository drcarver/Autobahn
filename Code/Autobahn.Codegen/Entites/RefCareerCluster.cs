using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefCareerCluster")]
    public partial class RefCareerCluster
    {
        public RefCareerCluster()
        {
            AeCourses = new HashSet<AeCourse>();
            CredentialDefinitions = new HashSet<CredentialDefinition>();
            CteCourses = new HashSet<CteCourse>();
            K12courses = new HashSet<K12course>();
            PsstudentPrograms = new HashSet<PsstudentProgram>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefCareerClusterId { get; set; }
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
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefCareerClusters")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefCareerCluster")]
        public virtual ICollection<AeCourse> AeCourses { get; set; }
        [InverseProperty("RefCareerCluster")]
        public virtual ICollection<CredentialDefinition> CredentialDefinitions { get; set; }
        [InverseProperty("RefCareerCluster")]
        public virtual ICollection<CteCourse> CteCourses { get; set; }
        [InverseProperty("RefCareerCluster")]
        public virtual ICollection<K12course> K12courses { get; set; }
        [InverseProperty("RefCareerCluster")]
        public virtual ICollection<PsstudentProgram> PsstudentPrograms { get; set; }
    }
}
