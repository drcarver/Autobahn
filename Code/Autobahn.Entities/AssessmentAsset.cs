using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentAsset")]
    public partial class AssessmentAsset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentAsset()
        {
            AssessmentFormAssessmentAsset = new HashSet<AssessmentFormAssessmentAsset>();
            AssessmentFormSectionAssessmentAsset = new HashSet<AssessmentFormSectionAssessmentAsset>();
        }

        public int AssessmentAssetId { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? RefAssessmentAssestIdentifierType { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        public int? RefAssessmentAssetTypeId { get; set; }

        [StringLength(60)]
        public string Owner { get; set; }

        public int? RefAssessmentLanguageId { get; set; }

        public string ContentXML { get; set; }

        public string ContentMimeType { get; set; }

        [StringLength(512)]
        public string ContentUrl { get; set; }

        public int? LearningResourceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentAssetIdentifierType RefAssessmentAssetIdentifierType { get; set; }

        public virtual RefAssessmentAssetType RefAssessmentAssetType { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormAssessmentAsset> AssessmentFormAssessmentAsset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSectionAssessmentAsset> AssessmentFormSectionAssessmentAsset { get; set; }
    }
}
