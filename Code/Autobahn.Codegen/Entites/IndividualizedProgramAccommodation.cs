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
    [Table("IndividualizedProgramAccommodation", Schema = "Common")]
    public partial class IndividualizedProgramAccommodation
    {
        public IndividualizedProgramAccommodation()
        {
            IndividualizedProgramAccommodationSubjects = new HashSet<IndividualizedProgramAccommodationSubject>();
        }

        [Key]
        public int IndividualizedProgramAccommodationId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public string? Description { get; set; }
        public string? Applicability { get; set; }
        public int? RefAccommodationTypeId { get; set; }
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
        [InverseProperty("IndividualizedProgramAccommodations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramAccommodations")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramAccommodations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAccommodationTypeId")]
        [InverseProperty("IndividualizedProgramAccommodations")]
        public virtual RefAccommodationType? RefAccommodationType { get; set; }
        [InverseProperty("IndividualizedProgramAccommodation")]
        public virtual ICollection<IndividualizedProgramAccommodationSubject> IndividualizedProgramAccommodationSubjects { get; set; }
    }
}
