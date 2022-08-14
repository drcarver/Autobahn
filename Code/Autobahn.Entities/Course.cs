using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            CourseSections = new HashSet<CourseSection>();
            CredentialCriteriaCourses = new HashSet<CredentialCriteriaCourse>();
            CteCourses = new HashSet<CteCourse>();
            K12Course = new HashSet<K12Course>();
            ProfessionalDevelopmentActivities = new HashSet<ProfessionalDevelopmentActivity>();
            PsCourses = new HashSet<PsCourse>();
        }

        public int CourseId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(60)]
        public string Description { get; set; }

        [StringLength(50)]
        public string SubjectAbbreviation { get; set; }

        [StringLength(50)]
        public string SCEDSequenceOfCourse { get; set; }

        public int? InstructionalMinutes { get; set; }

        public decimal? CreditValue { get; set; }

        [StringLength(300)]
        public string CertificationDescription { get; set; }

        public int? RepeatabilityMaximumNumber { get; set; }

        public int? RefCourseLevelCharacteristicsId { get; set; }

        public int? RefCourseCreditUnitId { get; set; }

        public int? RefInstructionLanguageId { get; set; }

        public int? RefCourseApplicableEducationLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCourseApplicableEducationLevel RefCourseApplicableEducationLevel { get; set; }

        public virtual RefCourseCreditUnit RefCourseCreditUnit { get; set; }

        public virtual RefCourseLevelCharacteristic RefCourseLevelCharacteristic { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CteCourse> CteCourses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12Course> K12Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsCourse> PsCourses { get; set; }
    }
}
