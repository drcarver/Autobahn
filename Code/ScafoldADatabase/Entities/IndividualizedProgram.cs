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
    [Table("IndividualizedProgram")]
    public partial class IndividualizedProgram
    {
        public IndividualizedProgram()
        {
            ElchildIndividualizedPrograms = new HashSet<ElchildIndividualizedProgram>();
            ElchildTransitionPlans = new HashSet<ElchildTransitionPlan>();
            Iepauthorizations = new HashSet<Iepauthorization>();
            IeppresentLevels = new HashSet<IeppresentLevel>();
            IndividualizedProgramAccommodations = new HashSet<IndividualizedProgramAccommodation>();
            IndividualizedProgramAmendments = new HashSet<IndividualizedProgramAmendment>();
            IndividualizedProgramAssessments = new HashSet<IndividualizedProgramAssessment>();
            IndividualizedProgramEligibilities = new HashSet<IndividualizedProgramEligibility>();
            IndividualizedProgramGoals = new HashSet<IndividualizedProgramGoal>();
            IndividualizedProgramMeetings = new HashSet<IndividualizedProgramMeeting>();
            IndividualizedProgramProgressReportPlans = new HashSet<IndividualizedProgramProgressReportPlan>();
            IndividualizedProgramProgressReports = new HashSet<IndividualizedProgramProgressReport>();
            IndividualizedProgramServicesReceiveds = new HashSet<IndividualizedProgramServicesReceived>();
        }

        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int IndividualizedProgramId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIndividualizedProgramDateType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? IndividualizedProgramDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NonInclusionMinutesPerWeek { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? InclusionMinutesPerWeek { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIndividualizedProgramTransitionTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIndividualizedProgramTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ServicePlanDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIndividualizedProgramLocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4000)]
        public string? ServicePlanMeetingParticipants { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4000)]
        public string? ServicePlanSignedBy { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ServicePlanSignatureDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ServicePlanReevaluationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefStudentSupportServiceTypeId { get; set; }
        public bool? InclusiveSettingIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ServicePlanEndDate { get; set; }
        public string? TransferOfRightsStatement { get; set; }
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
        [InverseProperty("IndividualizedPrograms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIndividualizedProgramDateType")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RefIndividualizedProgramDateType? RefIndividualizedProgramDateTypeNavigation { get; set; }
        [ForeignKey("RefIndividualizedProgramLocationId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RefIndividualizedProgramLocation? RefIndividualizedProgramLocation { get; set; }
        [ForeignKey("RefIndividualizedProgramTransitionTypeId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RefIndividualizedProgramTransitionType? RefIndividualizedProgramTransitionType { get; set; }
        [ForeignKey("RefIndividualizedProgramTypeId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RefIndividualizedProgramType? RefIndividualizedProgramType { get; set; }
        [ForeignKey("RefStudentSupportServiceTypeId")]
        [InverseProperty("IndividualizedPrograms")]
        public virtual RefStudentSupportServiceType? RefStudentSupportServiceType { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<ElchildIndividualizedProgram> ElchildIndividualizedPrograms { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<ElchildTransitionPlan> ElchildTransitionPlans { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<Iepauthorization> Iepauthorizations { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IeppresentLevel> IeppresentLevels { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramAccommodation> IndividualizedProgramAccommodations { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramAmendment> IndividualizedProgramAmendments { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramEligibility> IndividualizedProgramEligibilities { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramGoal> IndividualizedProgramGoals { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramMeeting> IndividualizedProgramMeetings { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramProgressReportPlan> IndividualizedProgramProgressReportPlans { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }
        [InverseProperty("IndividualizedProgram")]
        public virtual ICollection<IndividualizedProgramServicesReceived> IndividualizedProgramServicesReceiveds { get; set; }
    }
}
