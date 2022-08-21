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
    [Table("RefServiceOption")]
    public partial class RefServiceOption
    {
        public RefServiceOption()
        {
            ElclassSections = new HashSet<ElclassSection>();
            Elenrollments = new HashSet<Elenrollment>();
            ElorganizationAvailabilities = new HashSet<ElorganizationAvailability>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefServiceOptionId { get; set; }
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
        [InverseProperty("RefServiceOptions")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefServiceOption")]
        public virtual ICollection<ElclassSection> ElclassSections { get; set; }
        [InverseProperty("RefServiceOption")]
        public virtual ICollection<Elenrollment> Elenrollments { get; set; }
        [InverseProperty("RefServiceOption")]
        public virtual ICollection<ElorganizationAvailability> ElorganizationAvailabilities { get; set; }
    }
}
