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
    [Table("Goal")]
    public partial class Goal
    {
        public Goal()
        {
            GoalMeasurements = new HashSet<GoalMeasurement>();
            GoalPerformances = new HashSet<GoalPerformance>();
            IndividualizedProgramGoals = new HashSet<IndividualizedProgramGoal>();
        }

        [Key]
        public int GoalId { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        public int? OrganizationPersonRoleId { get; set; }
        public int? CompetencySetId { get; set; }
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

        [ForeignKey("CompetencySetId")]
        [InverseProperty("Goals")]
        public virtual CompetencySet? CompetencySet { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("Goals")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("Goals")]
        public virtual OrganizationPersonRole? OrganizationPersonRole { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Goals")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("Goal")]
        public virtual ICollection<GoalMeasurement> GoalMeasurements { get; set; }
        [InverseProperty("Goal")]
        public virtual ICollection<GoalPerformance> GoalPerformances { get; set; }
        [InverseProperty("Goal")]
        public virtual ICollection<IndividualizedProgramGoal> IndividualizedProgramGoals { get; set; }
    }
}
