using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearnerAction")]
    public partial class LearnerAction
    {
        public int LearnerActionId { get; set; }

        public int? AssessmentItemResponseId { get; set; }

        public int? RefLearnerActionTypeId { get; set; }

        public string Value { get; set; }

        public DateTime? LearnerActionDateTime { get; set; }

        [StringLength(40)]
        public string LearnerActionActorIdentifier { get; set; }

        [StringLength(300)]
        public string LearnerActionObjectDescription { get; set; }

        [StringLength(40)]
        public string LearnerActionObjectIdentifier { get; set; }

        [StringLength(60)]
        public string LearnerActionObjectType { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItemResponse AssessmentItemResponse { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLearnerActionType RefLearnerActionType { get; set; }
    }
}
