using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12StudentAcademicHonor")]
    public partial class K12StudentAcademicHonor
    {
        public int K12StudentAcademicHonorId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefAcademicHonorTypeId { get; set; }

        [StringLength(80)]
        public string HonorDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAcademicHonorType RefAcademicHonorType { get; set; }
    }
}
