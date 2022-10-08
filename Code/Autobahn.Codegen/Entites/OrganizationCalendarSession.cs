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
    [Table("OrganizationCalendarSession", Schema = "Organization")]
    public partial class OrganizationCalendarSession
    {
        public OrganizationCalendarSession()
        {
            CourseSections = new HashSet<CourseSection>();
            K12federalFundAllocations = new HashSet<K12FederalFundAllocation>();
            K12leaFederalFunds = new HashSet<K12LeaFederalFunds>();
            K12studentSessions = new HashSet<K12StudentSession>();
            LearnerActivities = new HashSet<LearnerActivity>();
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationCalendarSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(7)]
        public string? Designator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? BeginDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSessionTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? InstructionalMinutes { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? MarkingTermIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? SchedulingTermIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AttendanceTermIndicator { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationCalendar.
        /// </summary>
        public int? OrganizationCalendarId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? DaysInSession { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? FirstInstructionDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? LastInstructionDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? MinutesPerDay { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? SessionStartTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? SessionEndTime { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAcademicTermDesignatorId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("OrganizationCalendarSessions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationCalendarId")]
        [InverseProperty("OrganizationCalendarSessions")]
        public virtual OrganizationCalendar? OrganizationCalendar { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationCalendarSessions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAcademicTermDesignatorId")]
        [InverseProperty("OrganizationCalendarSessions")]
        public virtual RefAcademicTermDesignator? RefAcademicTermDesignator { get; set; }
        [ForeignKey("RefSessionTypeId")]
        [InverseProperty("OrganizationCalendarSessions")]
        public virtual RefSessionType? RefSessionType { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<K12FederalFundAllocation> K12federalFundAllocations { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<K12LeaFederalFunds> K12leaFederalFunds { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<K12StudentSession> K12studentSessions { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
        [InverseProperty("OrganizationCalendarSession")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
