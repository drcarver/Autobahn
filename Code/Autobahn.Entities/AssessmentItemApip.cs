using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemApip")]
    public partial class AssessmentItemApip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentItemApip()
        {
            ApipInteractions = new HashSet<ApipInteraction>();
            AssessmentItemApipDescriptions = new HashSet<AssessmentItemApipDescription>();
        }

        public int AssessmentItemApipId { get; set; }

        public int AssessmentItemId { get; set; }

        public bool? AdaptiveIndicator { get; set; }

        [StringLength(512)]
        public string ResponseProcessingTemplateUrl { get; set; }

        public string ResponseProcessingXml { get; set; }

        public string ResponseDeclarationXml { get; set; }

        public string OutcomeDeclarationXml { get; set; }

        public string TemplateDeclarationXml { get; set; }

        public string TemplateProcessingXml { get; set; }

        public string ModalFeedbackXml { get; set; }

        public string ItemBodyXml { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApipInteraction> ApipInteractions { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemApipDescription> AssessmentItemApipDescriptions { get; set; }
    }
}
