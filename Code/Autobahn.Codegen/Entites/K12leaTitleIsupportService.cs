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
    [Table("K12LeaTitleISupportService", Schema = "K12")]
    public partial class K12LeaTitleISupportService
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int K12LeaTitleISupportServiceId { get; set; }
        public int K12LeaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefK12LeaTitleISupportServiceId { get; set; }
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
        public virtual K12Lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefK12leaTitleIsupportServiceId")]
        [InverseProperty("K12leaTitleIsupportServices")]
        public virtual RefK12leaTitleIsupportService RefK12leaTitleIsupportService { get; set; } = null!;
    }
}
