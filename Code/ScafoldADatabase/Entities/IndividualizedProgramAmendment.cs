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
    [Table("IndividualizedProgramAmendment")]
    public partial class IndividualizedProgramAmendment
    {
        [Key]
        public int IndividualizedProgramAmendmentId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public string? Description { get; set; }
        public string? ReasonDescription { get; set; }
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
        [InverseProperty("IndividualizedProgramAmendments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramAmendments")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramAmendments")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
