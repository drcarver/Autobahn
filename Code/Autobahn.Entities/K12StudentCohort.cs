using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12StudentCohort")]
    public partial class K12StudentCohort
    {
        public int K12StudentCohortId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(4)]
        public string CohortYear { get; set; }

        [StringLength(4)]
        public string CohortGraduationYear { get; set; }

        [StringLength(4)]
        public string GraduationRateSurveyCohortYear { get; set; }

        public bool? GraduationRateSurveyIndicator { get; set; }

        [StringLength(30)]
        public string CohortDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
