using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SchoolImprovement")]
    public partial class K12SchoolImprovement
    {
        public int K12SchoolImprovementId { get; set; }

        public int K12SchoolId { get; set; }

        public int? RefSchoolImprovementStatusId { get; set; }

        public int? RefSchoolImprovementFundsId { get; set; }

        public int? RefSigInterventionTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SchoolImprovementExitDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefSchoolImprovementFund RefSchoolImprovementFund { get; set; }

        public virtual RefSchoolImprovementStatus RefSchoolImprovementStatus { get; set; }

        public virtual RefSigInterventionType RefSigInterventionType { get; set; }
    }
}
