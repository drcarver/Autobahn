using System;

namespace Autobahn.Entities
{
    public partial class K12StudentActivity
    {
        public int K12StudentActivityId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? ActivityTimeInvolved { get; set; }

        public int? RefActivityTimeMeasurementTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefActivityTimeMeasurementType RefActivityTimeMeasurementType { get; set; }
    }
}
