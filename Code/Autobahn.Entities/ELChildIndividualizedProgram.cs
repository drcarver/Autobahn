using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildIndividualizedProgram")]
    public partial class ELChildIndividualizedProgram
    {
        public int ELChildIndividualizedProgramId { get; set; }

        public int PersonId { get; set; }

        public int? IndividualizedProgramId { get; set; }

        public int? RefIDEAIEPStatusId { get; set; }

        public int? RefIDEAPartCEligibilityCategoryId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIDEAIEPStatus RefIDEAIEPStatus { get; set; }

        public virtual RefIDEAPartCEligibilityCategory RefIDEAPartCEligibilityCategory { get; set; }
    }
}
