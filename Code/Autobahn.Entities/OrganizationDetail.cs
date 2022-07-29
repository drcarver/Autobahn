using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationDetail")]
    public partial class OrganizationDetail
    {
        public int OrganizationDetailId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(30)]
        public string ShortName { get; set; }

        [StringLength(2000)]
        public string RegionGeoJSON { get; set; }

        public int? RefOrganizationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationType RefOrganizationType { get; set; }
    }
}
