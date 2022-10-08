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
    [Table("CourseSectionAssessmentReporting", Schema = "Assessment")]
    public partial class CourseSectionAssessmentReporting
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int CourseSectionAssessmentReportingId { get; set; }
        public int? CourseSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseSectionAssessmentReportingMethodId { get; set; }
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

        [ForeignKey("CourseSectionId")]
        [InverseProperty("CourseSectionAssessmentReportings")]
        public virtual CourseSection? CourseSection { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CourseSectionAssessmentReportings")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CourseSectionAssessmentReportings")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseSectionAssessmentReportingMethodId")]
        [InverseProperty("CourseSectionAssessmentReportings")]
        public virtual RefCourseSectionAssessmentReportingMethod? RefCourseSectionAssessmentReportingMethod { get; set; }
    }
}
