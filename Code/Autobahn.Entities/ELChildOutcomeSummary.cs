using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildOutcomeSummary")]
    public partial class ELChildOutcomeSummary
    {
        public int ELChildOutcomeSummaryId { get; set; }

        public int PersonId { get; set; }

        public bool? COSProgressAIndicator { get; set; }

        public bool? COSProgressBIndicator { get; set; }

        public bool? COSProgressCIndicator { get; set; }

        public int? COSRatingAId { get; set; }

        public int? COSRatingBId { get; set; }

        public int? COSRatingCId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RefChildOutcomesSummaryRating RefChildOutcomesSummaryRating { get; set; }

        public virtual RefChildOutcomesSummaryRating RefChildOutcomesSummaryRating1 { get; set; }

        public virtual RefChildOutcomesSummaryRating RefChildOutcomesSummaryRating2 { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
