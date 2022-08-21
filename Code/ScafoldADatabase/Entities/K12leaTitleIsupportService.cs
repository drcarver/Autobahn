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
    [Table("K12LeaTitleISupportService")]
    public partial class K12leaTitleIsupportService
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12LeaTitleISupportServiceId")]
        public int K12leaTitleIsupportServiceId { get; set; }
        [Column("K12LeaId")]
        public int K12leaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefK12LeaTitleISupportServiceId")]
        public int RefK12leaTitleIsupportServiceId { get; set; }
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
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual K12lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefK12leaTitleIsupportServiceId")]
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual RefK12leaTitleIsupportService RefK12leaTitleIsupportService { get; set; } = null!;
    }
}
