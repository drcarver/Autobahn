using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsCourse")]
    public partial class PsCourse
    {
        public int PsCourseId { get; set; }

        public int CourseId { get; set; }

        [StringLength(30)]
        public string CourseNumber { get; set; }

        [StringLength(40)]
        public string OriginalCourseIdentifier { get; set; }

        [StringLength(30)]
        public string OverrideSchoolCourseNumber { get; set; }

        public int? NCAAEligibilityInd { get; set; }

        public int? RefCourseCreditBasisTypeId { get; set; }

        public int? RefCourseCreditLevelTypeId { get; set; }

        public int? RefNCESCollegeCourseMapCodeId { get; set; }

        public int? RefCipCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual Course Course { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCipCode RefCipCode { get; set; }

        public virtual RefCourseCreditBasisType RefCourseCreditBasisType { get; set; }

        public virtual RefCourseCreditLevelType RefCourseCreditLevelType { get; set; }

        public virtual RefNCESCollegeCourseMapCode RefNCESCollegeCourseMapCode { get; set; }
    }
}
