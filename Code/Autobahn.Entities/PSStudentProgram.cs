using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PSStudentProgram")]
    public partial class PSStudentProgram
    {
        public int PSStudentProgramId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefCipUseId { get; set; }

        public int? PsProgramId { get; set; }

        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }

        public int? RefTransferOutIndicatorId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefCareerClusterId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual PsProgram PsProgram { get; set; }

        public virtual RefCipUse RefCipUse { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCareerCluster RefCareerCluster { get; set; }

        public virtual RefTransferOutIndicator RefTransferOutIndicator { get; set; }

        public virtual RefWorkbasedLearningOpportunityType RefWorkbasedLearningOpportunityType { get; set; }
    }
}
