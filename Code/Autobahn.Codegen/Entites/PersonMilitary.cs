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
    [Table("PersonMilitary", Schema = "Person")]
    public partial class PersonMilitary
    {
        [Key]
        public int PersonMilitaryId { get; set; }
        /// <summary>
        /// Surrogate key from Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMilitaryActiveStudentIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMilitaryConnectedStudentIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMilitaryVeteranStudentIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMilitaryBranchId { get; set; }
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
        [InverseProperty("PersonMilitaries")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonMilitaries")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonMilitaries")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefMilitaryActiveStudentIndicatorId")]
        [InverseProperty("PersonMilitaries")]
        public virtual RefMilitaryActiveStudentIndicator? RefMilitaryActiveStudentIndicator { get; set; }
        [ForeignKey("RefMilitaryBranchId")]
        [InverseProperty("PersonMilitaries")]
        public virtual RefMilitaryBranch? RefMilitaryBranch { get; set; }
        [ForeignKey("RefMilitaryConnectedStudentIndicatorId")]
        [InverseProperty("PersonMilitaries")]
        public virtual RefMilitaryConnectedStudentIndicator? RefMilitaryConnectedStudentIndicator { get; set; }
        [ForeignKey("RefMilitaryVeteranStudentIndicatorId")]
        [InverseProperty("PersonMilitaries")]
        public virtual RefMilitaryVeteranStudentIndicator? RefMilitaryVeteranStudentIndicator { get; set; }
    }
}
