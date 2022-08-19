using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentApplication")]
    public partial class PsStudentApplication
    {
        public int PsStudentApplicationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? PostsecondaryApplicant { get; set; }

        public decimal? GradePointAverageCumulative { get; set; }

        public decimal? HighSchoolPercentile { get; set; }

        public int? HighSchoolStudentClassRank { get; set; }

        public int? HighSchoolGraduatingClassSize { get; set; }

        public bool? WaitListedStudent { get; set; }

        public int? RefGradePointAverageDomainId { get; set; }

        public int? RefGpaWeightedIndicatorId { get; set; }

        public int? RefAdmittedStudentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdmittedStudent RefAdmittedStudent { get; set; }

        public virtual RefGpaWeightedIndicator RefGpaWeightedIndicator { get; set; }

        public virtual RefGradePointAverageDomain RefGradePointAverageDomain { get; set; }
    }
}
