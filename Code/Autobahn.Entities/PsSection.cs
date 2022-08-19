using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsSection")]
    public partial class PsSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PsSection()
        {
            PsSectionLocations = new HashSet<PsSectionLocation>();
        }

        public int PsSectionId { get; set; }

        public int CourseSectionId { get; set; }

        [StringLength(2)]
        public string GradeValueQualifier { get; set; }

        public int? RefCipCodeId { get; set; }

        public int? RefCourseGPAApplicabilityId { get; set; }

        public int? RefCourseHonorsTypeId { get; set; }

        public int? RefCourseInstructionMethodId { get; set; }

        public int? RefCourseLevelTypeId { get; set; }

        public int? RefDevelopmentalEducationTypeId { get; set; }

        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RefCourseGpaApplicability RefCourseGpaApplicability { get; set; }

        public virtual RefCourseHonorsType RefCourseHonorsType { get; set; }

        public virtual RefCourseInstructionMethod RefCourseInstructionMethod { get; set; }

        public virtual RefCourseLevelType RefCourseLevelType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCipCode RefCipCode { get; set; }

        public virtual RefDevelopmentalEducationType RefDevelopmentalEducationType { get; set; }

        public virtual RefWorkbasedLearningOpportunityType RefWorkbasedLearningOpportunityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsSectionLocation> PsSectionLocations { get; set; }
    }
}
