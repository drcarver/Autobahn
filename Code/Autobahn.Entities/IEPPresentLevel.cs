using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IEPPresentLevel")]
    public partial class IEPPresentLevel
    {
        public int IEPPresentLevelId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public string AcademicDescription { get; set; }

        public string FunctionalDescription { get; set; }

        public string GeneralEducationDescription { get; set; }

        public string ParentConcernDescription { get; set; }

        public string PreschoolDescription { get; set; }

        public string StudentConcernDescription { get; set; }

        public string StudentStrengthsDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
