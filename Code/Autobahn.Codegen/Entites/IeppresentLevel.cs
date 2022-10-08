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
    [Table("IEPPresentLevel")]
    public partial class IEPPresentLevel
    {
        [Key]
        public int IEPPresentLevelId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public string? AcademicDescription { get; set; }
        public string? FunctionalDescription { get; set; }
        public string? GeneralEducationDescription { get; set; }
        public string? ParentConcernDescription { get; set; }
        public string? PreschoolDescription { get; set; }
        public string? StudentConcernDescription { get; set; }
        public string? StudentStrengthsDescription { get; set; }
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
        [InverseProperty("IeppresentLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IeppresentLevels")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IeppresentLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
