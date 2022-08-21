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
    [Table("AssessmentSessionStaffRole")]
    public partial class AssessmentSessionStaffRole
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSessionStaffRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentSessionStaffRoleTypeId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSession
        /// </summary>
        public int? AssessmentSessionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentParticipantSession
        /// </summary>
        public int? AssessmentParticipantSessionId { get; set; }
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

        [ForeignKey("AssessmentParticipantSessionId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual AssessmentParticipantSession? AssessmentParticipantSession { get; set; }
        [ForeignKey("AssessmentSessionId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual AssessmentSession? AssessmentSession { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentSessionStaffRoleTypeId")]
        [InverseProperty("AssessmentSessionStaffRoles")]
        public virtual RefAssessmentSessionStaffRoleType? RefAssessmentSessionStaffRoleType { get; set; }
    }
}
