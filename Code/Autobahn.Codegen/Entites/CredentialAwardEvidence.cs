using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("CredentialAwardEvidence", Schema = "Assessment")]
    public partial class CredentialAwardEvidence
    {
        [Key]
        public int CredentialAwardEvidenceId { get; set; }
        public int CredentialAwardId { get; set; }
        [StringLength(300)]
        public string? Statement { get; set; }
        public int? AssessmentResultId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AssessmentResultId")]
        [InverseProperty("CredentialAwardEvidences")]
        public virtual AssessmentResult? AssessmentResult { get; set; }
        [ForeignKey("CredentialAwardId")]
        [InverseProperty("CredentialAwardEvidences")]
        public virtual CredentialAward CredentialAward { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialAwardEvidences")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialAwardEvidences")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
