using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentSection")]
    public partial class PsStudentSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PsStudentSection()
        {
            PsStudentCourseSectionMarks = new HashSet<PsStudentCourseSectionMark>();
        }

        public int PsStudentSectionId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(80)]
        public string CourseOverrideSchool { get; set; }

        public bool? DegreeApplicability { get; set; }

        [StringLength(15)]
        public string AcademicGrade { get; set; }

        public decimal? NumberOfCreditsEarned { get; set; }

        public decimal? QualityPointsEarned { get; set; }

        public int? RefCourseRepeatCodeId { get; set; }

        public int? RefCourseAcademicGradeStatusCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public decimal? NumberOfCreditsAttempted { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsStudentCourseSectionMark> PsStudentCourseSectionMarks { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCourseAcademicGradeStatusCode RefCourseAcademicGradeStatusCode { get; set; }

        public virtual RefCourseRepeatCode RefCourseRepeatCode { get; set; }
    }
}
