using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12LeaFederalReporting")]
    public partial class K12LeaFederalReporting
    {
        public int K12LeaFederalReportingId { get; set; }

        public int K12LeaId { get; set; }

        public bool? DesegregationOrderOrPlan { get; set; }

        public bool? HarassmentOrBullyingPolicy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StateAssessmentAdminFunding { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StateAssessStandardsFunding { get; set; }

        public bool? TerminatedTitleIIIProgramFailure { get; set; }

        public int? InterscholasticSportsMaleOnly { get; set; }

        public int? InterscholasticSportsFemaleOnly { get; set; }

        public int? InterscholasticTeamsMaleOnly { get; set; }

        public int? InterscholasticTeamsFemaleOnly { get; set; }

        public int? InterscholasticSportParticipantsMale { get; set; }

        public int? InterscholasticSportParticipantsFemale { get; set; }

        public int? RefBarrierToEducatingHomelessId { get; set; }

        public int? RefIntegratedTechnologyStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Lea K12Lea { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBarrierToEducatingHomeless RefBarrierToEducatingHomeless { get; set; }

        public virtual RefIntegratedTechnologyStatus RefIntegratedTechnologyStatus { get; set; }
    }
}
