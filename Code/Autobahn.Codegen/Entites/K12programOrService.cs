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
    [Table("K12ProgramOrService")]
    public partial class K12programOrService
    {
        [Key]
        [Column("K12ProgramOrServiceId")]
        public int K12programOrServiceId { get; set; }
        /// <summary>
        /// Surrogate key from K12LEA.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ProgramInMultiplePurposeFacility { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPrekindergartenDailyLengthId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefKindergartenDailyLengthId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgramGiftedEligibilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMepSessionTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMepProjectTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefTitleIInstructionalServicesId")]
        public int? RefTitleIinstructionalServicesId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefTitleIProgramTypeId")]
        public int? RefTitleIprogramTypeId { get; set; }
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
        [InverseProperty("K12programOrServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12programOrServices")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12programOrServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefKindergartenDailyLengthId")]
        [InverseProperty("K12programOrServiceRefKindergartenDailyLengths")]
        public virtual RefProgramDayLength? RefKindergartenDailyLength { get; set; }
        [ForeignKey("RefMepProjectTypeId")]
        [InverseProperty("K12programOrServices")]
        public virtual RefMepProjectType? RefMepProjectType { get; set; }
        [ForeignKey("RefMepSessionTypeId")]
        [InverseProperty("K12programOrServices")]
        public virtual RefMepSessionType? RefMepSessionType { get; set; }
        [ForeignKey("RefPrekindergartenDailyLengthId")]
        [InverseProperty("K12programOrServiceRefPrekindergartenDailyLengths")]
        public virtual RefProgramDayLength? RefPrekindergartenDailyLength { get; set; }
        [ForeignKey("RefProgramGiftedEligibilityId")]
        [InverseProperty("K12programOrServices")]
        public virtual RefProgramGiftedEligibility? RefProgramGiftedEligibility { get; set; }
        [ForeignKey("RefTitleIinstructionalServicesId")]
        [InverseProperty("K12programOrServices")]
        public virtual RefTitleIinstructionalService? RefTitleIinstructionalServices { get; set; }
        [ForeignKey("RefTitleIprogramTypeId")]
        [InverseProperty("K12programOrServices")]
        public virtual RefTitleIprogramType? RefTitleIprogramType { get; set; }
    }
}
