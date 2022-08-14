using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilitySchoolDesign")]
    public partial class FacilitySchoolDesign
    {
        public int FacilitySchoolDesignId { get; set; }

        public int FacilityDesignId { get; set; }

        public int RefBuildingSchoolDesignTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual FacilityDesign FacilityDesign { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingSchoolDesignType RefBuildingSchoolDesignType { get; set; }
    }
}
