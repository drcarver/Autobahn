using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationEmployeeBenefit")]
    public partial class OrganizationEmployeeBenefit
    {
        public int OrganizationEmployeeBenefitId { get; set; }

        public Guid OrganizationId { get; set; }

        public bool? FullTimeBenefitIndicator { get; set; }

        public bool? PartTimeBenefitIndicator { get; set; }

        public int? RefEmployeeBenefitId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmployeeBenefit RefEmployeeBenefit { get; set; }
    }
}
