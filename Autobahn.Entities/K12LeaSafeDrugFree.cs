using System;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class K12LeaSafeDrugFree
    {
        public int K12LeaSafeDrugFreeId { get; set; }

        public int K12LeaId { get; set; }

        [StringLength(60)]
        public string Baseline { get; set; }

        [StringLength(20)]
        public string BaselineYear { get; set; }

        [StringLength(60)]
        public string CollectionFrequency { get; set; }

        [StringLength(60)]
        public string IndicatorName { get; set; }

        [StringLength(100)]
        public string Instrument { get; set; }

        [StringLength(20)]
        public string Performance { get; set; }

        [StringLength(20)]
        public string Target { get; set; }

        [StringLength(20)]
        public string MostRecentCollection { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Lea K12Lea { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
