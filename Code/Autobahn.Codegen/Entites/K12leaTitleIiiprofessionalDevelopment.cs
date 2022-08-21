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
    [Table("K12LeaTitleIIIProfessionalDevelopment")]
    [Index("K12leaId", "RefTitleIiiprofessionalDevelopmentTypeId", Name = "IX_K12LeaTitleIIIProfessionalDevelopment", IsUnique = true)]
    public partial class K12leaTitleIiiprofessionalDevelopment
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12LEATitleIIIProfessionalDevelopmentId")]
        public int K12leatitleIiiprofessionalDevelopmentId { get; set; }
        [Column("K12LeaId")]
        public int K12leaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefTitleIIIProfessionalDevelopmentTypeId")]
        public int RefTitleIiiprofessionalDevelopmentTypeId { get; set; }
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
        [InverseProperty("K12leaTitleIiiprofessionalDevelopments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaTitleIiiprofessionalDevelopments")]
        public virtual K12lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaTitleIiiprofessionalDevelopments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTitleIiiprofessionalDevelopmentTypeId")]
        [InverseProperty("K12leaTitleIiiprofessionalDevelopments")]
        public virtual RefTitleIiiprofessionalDevelopmentType RefTitleIiiprofessionalDevelopmentType { get; set; } = null!;
    }
}
