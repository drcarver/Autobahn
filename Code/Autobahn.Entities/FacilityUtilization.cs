using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityUtilization")]
    public partial class FacilityUtilization
    {
        public int FacilityUtilizationId { get; set; }

        public int FacilityId { get; set; }

        public int? BuildingHoursOfPublicUsePerWeek { get; set; }

        public decimal? BuildingNetAreaOfInstructionalSpace { get; set; }

        public int? BuildingNumberOfTeachingStations { get; set; }

        [StringLength(80)]
        public string BuildingPublicUsePolicyDescription { get; set; }

        public int? FacilityEnrollmentCapacity { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
