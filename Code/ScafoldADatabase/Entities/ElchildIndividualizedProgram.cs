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
    [Table("ELChildIndividualizedProgram")]
    public partial class ElchildIndividualizedProgram
    {
        [Key]
        [Column("ELChildIndividualizedProgramId")]
        public int ElchildIndividualizedProgramId { get; set; }
        /// <summary>
        /// Surrogate key from Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Foreign key - IndividualizedProgram
        /// </summary>
        public int? IndividualizedProgramId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefIDEAIEPStatusId")]
        public int? RefIdeaiepstatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefIDEAPartCEligibilityCategoryId")]
        public int? RefIdeapartCeligibilityCategoryId { get; set; }
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
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual IndividualizedProgram? IndividualizedProgram { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIdeaiepstatusId")]
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual RefIdeaiepstatus? RefIdeaiepstatus { get; set; }
        [ForeignKey("RefIdeapartCeligibilityCategoryId")]
        [InverseProperty("ElchildIndividualizedPrograms")]
        public virtual RefIdeapartCeligibilityCategory? RefIdeapartCeligibilityCategory { get; set; }
    }
}
