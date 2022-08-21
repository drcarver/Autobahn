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
    [Table("K12StudentDiscipline")]
    public partial class K12studentDiscipline
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12StudentDisciplineId")]
        public int K12studentDisciplineId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDisciplineReasonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDisciplinaryActionTakenId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DisciplinaryActionStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DisciplinaryActionEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? DurationOfDisciplinaryAction { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDisciplineLengthDifferenceReasonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FullYearExpulsion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ShortenedExpulsion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? EducationalServicesAfterRemoval { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIdeaInterimRemovalId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIdeaInterimRemovalReasonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? RelatedToZeroTolerancePolicy { get; set; }
        /// <summary>
        /// Surrogate Key
        /// </summary>
        public int? IncidentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("IEPPlacementMeetingIndicator")]
        public bool? IepplacementMeetingIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDisciplineMethodFirearmsId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDisciplineMethodOfCwdId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefIDEADisciplineMethodFirearmId")]
        public int? RefIdeadisciplineMethodFirearmId { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IncidentId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual Incident? Incident { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefDisciplinaryActionTakenId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefDisciplinaryActionTaken? RefDisciplinaryActionTaken { get; set; }
        [ForeignKey("RefDisciplineLengthDifferenceReasonId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefDisciplineLengthDifferenceReason? RefDisciplineLengthDifferenceReason { get; set; }
        [ForeignKey("RefDisciplineMethodFirearmsId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefDisciplineMethodFirearm? RefDisciplineMethodFirearms { get; set; }
        [ForeignKey("RefDisciplineMethodOfCwdId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefDisciplineMethodOfCwd? RefDisciplineMethodOfCwd { get; set; }
        [ForeignKey("RefDisciplineReasonId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefDisciplineReason? RefDisciplineReason { get; set; }
        [ForeignKey("RefIdeaInterimRemovalId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefIdeainterimRemoval? RefIdeaInterimRemoval { get; set; }
        [ForeignKey("RefIdeaInterimRemovalReasonId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefIdeainterimRemovalReason? RefIdeaInterimRemovalReason { get; set; }
        [ForeignKey("RefIdeadisciplineMethodFirearmId")]
        [InverseProperty("K12studentDisciplines")]
        public virtual RefIdeadisciplineMethodFirearm? RefIdeadisciplineMethodFirearm { get; set; }
    }
}
