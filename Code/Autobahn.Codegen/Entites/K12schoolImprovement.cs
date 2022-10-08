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
    [Table("K12SchoolImprovement", Schema = "K12")]
    public partial class K12SchoolImprovement
    {
        [Key]
        public int K12SchoolImprovementId { get; set; }
        public int K12SchoolId { get; set; }
        public int? RefSchoolImprovementStatusId { get; set; }
        public int? RefSchoolImprovementFundsId { get; set; }
        public int? RefSigInterventionTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? SchoolImprovementExitDate { get; set; }
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
        [InverseProperty("K12schoolImprovements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12schoolId")]
        [InverseProperty("K12schoolImprovements")]
        public virtual K12School K12school { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schoolImprovements")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefSchoolImprovementFundsId")]
        [InverseProperty("K12schoolImprovements")]
        public virtual RefSchoolImprovementFund? RefSchoolImprovementFunds { get; set; }
        [ForeignKey("RefSchoolImprovementStatusId")]
        [InverseProperty("K12schoolImprovements")]
        public virtual RefSchoolImprovementStatus? RefSchoolImprovementStatus { get; set; }
        [ForeignKey("RefSigInterventionTypeId")]
        [InverseProperty("K12schoolImprovements")]
        public virtual RefSigInterventionType? RefSigInterventionType { get; set; }
    }
}
