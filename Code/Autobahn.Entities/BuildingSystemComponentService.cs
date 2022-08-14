using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("BuildingSystemComponentService")]
    public partial class BuildingSystemComponentService
    {
        public int BuildingSystemComponentServiceId { get; set; }

        public int BuildingSystemComponentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureServicedDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual BuildingSystemComponent BuildingSystemComponent { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
