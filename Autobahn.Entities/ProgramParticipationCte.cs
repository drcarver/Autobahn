using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationCte")]
    public partial class ProgramParticipationCte
    {
        public int PersonProgramParticipationId { get; set; }

        public bool? CteParticipant { get; set; }

        public bool? CteConcentrator { get; set; }

        public bool? CteCompleter { get; set; }

        public bool? SingleParentOrSinglePregnantWoman { get; set; }

        public bool? DisplacedHomemakerIndicator { get; set; }

        public bool? CteNonTraditionalCompletion { get; set; }

        public int? RefNonTraditionalGenderStatusId { get; set; }

        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int ProgramParticipationCteId { get; set; }

        public bool? OutOfWorkforceIndicator { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefNonTraditionalGenderStatu RefNonTraditionalGenderStatu { get; set; }

        public virtual RefWorkbasedLearningOpportunityType RefWorkbasedLearningOpportunityType { get; set; }
    }
}