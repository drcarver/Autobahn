using System;

namespace Autobahn.Entities
{
    public partial class K12StudentSession
    {
        public int K12StudentSessionId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? OrganizationCalendarSessionId { get; set; }

        public decimal? GradePointAverageGivenSession { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}