using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonMilitary")]
    public partial class PersonMilitary
    {
        public int PersonMilitaryId { get; set; }

        public int PersonId { get; set; }

        public int? RefMilitaryActiveStudentIndicatorId { get; set; }

        public int? RefMilitaryConnectedStudentIndicatorId { get; set; }

        public int? RefMilitaryVeteranStudentIndicatorId { get; set; }

        public int? RefMilitaryBranchId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefMilitaryActiveStudentIndicator RefMilitaryActiveStudentIndicator { get; set; }

        public virtual RefMilitaryBranch RefMilitaryBranch { get; set; }

        public virtual RefMilitaryConnectedStudentIndicator RefMilitaryConnectedStudentIndicator { get; set; }

        public virtual RefMilitaryVeteranStudentIndicator RefMilitaryVeteranStudentIndicator { get; set; }
    }
}
