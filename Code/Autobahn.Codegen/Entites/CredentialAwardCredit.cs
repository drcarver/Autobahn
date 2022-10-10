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
    [Table("CredentialAwardCredit", Schema = "Education.Common")]
    public partial class CredentialAwardCredit
    {
        [Key]
        public int CredentialAwardCreditId { get; set; }
        public int CredentialAwardId { get; set; }
        public int? CredentialCriteriaCourseId { get; set; }
        public int? OrganizationPersonRoleId { get; set; }
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

        [ForeignKey("CredentialAwardId")]
        [InverseProperty("CredentialAwardCredits")]
        public virtual CredentialAward CredentialAward { get; set; } = null!;
        [ForeignKey("CredentialCriteriaCourseId")]
        [InverseProperty("CredentialAwardCredits")]
        public virtual CredentialCriteriaCourse? CredentialCriteriaCourse { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialAwardCredits")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("CredentialAwardCredits")]
        public virtual OrganizationPersonRole? OrganizationPersonRole { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialAwardCredits")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
