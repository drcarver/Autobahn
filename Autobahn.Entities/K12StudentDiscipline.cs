using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12StudentDiscipline
    {
        public int K12StudentDisciplineId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefDisciplineReasonId { get; set; }

        public int? RefDisciplinaryActionTakenId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DisciplinaryActionStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DisciplinaryActionEndDate { get; set; }

        public decimal? DurationOfDisciplinaryAction { get; set; }

        public int? RefDisciplineLengthDifferenceReasonId { get; set; }

        public bool? FullYearExpulsion { get; set; }

        public bool? ShortenedExpulsion { get; set; }

        public bool? EducationalServicesAfterRemoval { get; set; }

        public int? RefIdeaInterimRemovalId { get; set; }

        public int? RefIdeaInterimRemovalReasonId { get; set; }

        public bool? RelatedToZeroTolerancePolicy { get; set; }

        public int? IncidentId { get; set; }

        public bool? IEPPlacementMeetingIndicator { get; set; }

        public int? RefDisciplineMethodFirearmsId { get; set; }

        public int? RefDisciplineMethodOfCwdId { get; set; }

        public int? RefIDEADisciplineMethodFirearmId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Incident Incident { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefDisciplinaryActionTaken RefDisciplinaryActionTaken { get; set; }

        public virtual RefDisciplineLengthDifferenceReason RefDisciplineLengthDifferenceReason { get; set; }

        public virtual RefDisciplineMethodFirearm RefDisciplineMethodFirearm { get; set; }

        public virtual RefDisciplineMethodOfCwd RefDisciplineMethodOfCwd { get; set; }

        public virtual RefDisciplineReason RefDisciplineReason { get; set; }

        public virtual RefIDEADisciplineMethodFirearm RefIDEADisciplineMethodFirearm { get; set; }

        public virtual RefIDEAInterimRemoval RefIDEAInterimRemoval { get; set; }

        public virtual RefIDEAInterimRemovalReason RefIDEAInterimRemovalReason { get; set; }
    }
}
