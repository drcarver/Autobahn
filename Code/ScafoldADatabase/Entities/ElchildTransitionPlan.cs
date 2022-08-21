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
    [Table("ELChildTransitionPlan")]
    public partial class ElchildTransitionPlan
    {
        [Key]
        [Column("ELChildTransitionPlanId")]
        public int ElchildTransitionPlanId { get; set; }
        /// <summary>
        /// Surrogate key from Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("PartB619PotentialEligibilityInd")]
        public bool? PartB619potentialEligibilityInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("IDEAPartCToPartBNotificationDate", TypeName = "date")]
        public DateTime? IdeapartCtoPartBnotificationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? TransitionConferenceDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? TransitionConferenceDeclineDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateOfTransitionPlan { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("IDEAPartCToPartBNotificationOptOutDate", TypeName = "date")]
        public DateTime? IdeapartCtoPartBnotificationOptOutDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("IDEAPartCToPartBNotificationOptOutIndicator")]
        public bool? IdeapartCtoPartBnotificationOptOutIndicator { get; set; }
        /// <summary>
        /// Foreign key - IndividualizedProgram
        /// </summary>
        public int? IndividualizedProgramId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefReasonDelayTransitionConfId { get; set; }
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
        [InverseProperty("ElchildTransitionPlans")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("ElchildTransitionPlans")]
        public virtual IndividualizedProgram? IndividualizedProgram { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("ElchildTransitionPlans")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElchildTransitionPlans")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefReasonDelayTransitionConfId")]
        [InverseProperty("ElchildTransitionPlans")]
        public virtual RefReasonDelayTransitionConf? RefReasonDelayTransitionConf { get; set; }
    }
}
