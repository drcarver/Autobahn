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
    [Table("CredentialCriteriaCourse", Schema = "Education.Common")]
    [Index("CourseId", "CredentialDefCriteriaId", Name = "IX_Course_CredentialCriteria", IsUnique = true)]
    public partial class CredentialCriteriaCourse
    {
        public CredentialCriteriaCourse()
        {
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
        }

        [Key]
        public int CredentialCriteriaCourseId { get; set; }
        public int CredentialDefCriteriaId { get; set; }
        public int CourseId { get; set; }
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

        [ForeignKey("CourseId")]
        [InverseProperty("CredentialCriteriaCourses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("CredentialDefCriteriaId")]
        [InverseProperty("CredentialCriteriaCourses")]
        public virtual CredentialDefCriterion CredentialDefCriteria { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialCriteriaCourses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialCriteriaCourses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("CredentialCriteriaCourse")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }
    }
}
