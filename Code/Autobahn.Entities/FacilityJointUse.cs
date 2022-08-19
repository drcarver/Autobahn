using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityJointUse")]
    public partial class FacilityJointUse
    {
        public int FacilityJointUseId { get; set; }

        public int FacilityId { get; set; }

        public int? RefBuildingJointUseRationaleTypeId { get; set; }

        public int? RefBuildingJointUserTypeId { get; set; }

        public int? RefBuildingJointUseSchedulingTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingJointUseRationaleType RefBuildingJointUseRationaleType { get; set; }

        public virtual RefBuildingJointUserType RefBuildingJointUserType { get; set; }

        public virtual RefBuildingJointUseSchedulingType RefBuildingJointUseSchedulingType { get; set; }
    }
}
