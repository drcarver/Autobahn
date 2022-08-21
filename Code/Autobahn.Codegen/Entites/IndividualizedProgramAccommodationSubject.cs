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
    [Table("IndividualizedProgramAccommodationSubject")]
    [Index("IndividualizedProgramAccommodationId", "RefScedcourseSubjectAreaId", Name = "IX_IndividualizedProgramAccommodation_RefSCEDCourseSubjectArea", IsUnique = true)]
    public partial class IndividualizedProgramAccommodationSubject
    {
        [Key]
        public int IndividualizedProgramAccommodationSubjectId { get; set; }
        public int IndividualizedProgramAccommodationId { get; set; }
        [Column("RefSCEDCourseSubjectAreaId")]
        public int RefScedcourseSubjectAreaId { get; set; }
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
        [InverseProperty("IndividualizedProgramAccommodationSubjects")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramAccommodationId")]
        [InverseProperty("IndividualizedProgramAccommodationSubjects")]
        public virtual IndividualizedProgramAccommodation IndividualizedProgramAccommodation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramAccommodationSubjects")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefScedcourseSubjectAreaId")]
        [InverseProperty("IndividualizedProgramAccommodationSubjects")]
        public virtual RefScedcourseSubjectArea RefScedcourseSubjectArea { get; set; } = null!;
    }
}
