using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilitySite")]
    public partial class FacilitySite
    {
        public int FacilitySiteId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(20)]
        public string FacilitySiteIdentifier { get; set; }

        public decimal? FacilitySiteArea { get; set; }

        public int? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        public int? RefFacilitySiteOutdoorAreaTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingSiteUseRestrictionsType RefBuildingSiteUseRestrictionsType { get; set; }

        public virtual RefFacilitySiteOutdoorAreaType RefFacilitySiteOutdoorAreaType { get; set; }
    }
}
