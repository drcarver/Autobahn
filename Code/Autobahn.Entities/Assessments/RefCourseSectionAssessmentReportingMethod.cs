//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   RefCourseSectionAssessmentReportingMethod.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Assessments
{
    [Table("RefCourseSectionAssessmentReportingMethod")]
    public partial class RefCourseSectionAssessmentReportingMethod : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefCourseSectionAssessmentReportingMethod()
        {
            CourseSectionAssessmentReportings = new HashSet<CourseSectionAssessmentReporting>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionAssessmentReporting> CourseSectionAssessmentReportings { get; set; }
    }
}
