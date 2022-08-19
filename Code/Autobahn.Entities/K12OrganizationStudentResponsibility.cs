using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12OrganizationStudentResponsibility")]
    public partial class K12OrganizationStudentResponsibility
    {
        public int K12OrganizationStudentResponsibilityId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int RefK12ResponsibilityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefStudentSchoolAffiliationStateDefinedStatus RefStudentSchoolAffiliationStateDefinedStatus { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefK12ResponsibilityType RefK12ResponsibilityType { get; set; }
    }
}
