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
    [Table("PersonFamily", Schema = "Person")]
    public partial class PersonFamily
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonFamilyId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? FamilyIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NumberOfPeopleInFamily { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NumberOfPeopleInHousehold { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? FamilyIncome { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFamilyIncomeSourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncomeCalculationMethodId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProofOfResidencyTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefELProgramEligibilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHighestEducationLevelCompletedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCommunicationMethodId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? IncludedInCountedFamilySize { get; set; }
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
        public int? NumberOfHouseholdCollegeStudents { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonFamilies")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonFamilies")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonFamilies")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCommunicationMethodId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefCommunicationMethod? RefCommunicationMethod { get; set; }
        [ForeignKey("RefElprogramEligibilityId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefELProgramEligibility? RefElprogramEligibility { get; set; }
        [ForeignKey("RefFamilyIncomeSourceId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefFamilyIncomeSource? RefFamilyIncomeSource { get; set; }
        [ForeignKey("RefHighestEducationLevelCompletedId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefEducationLevel? RefHighestEducationLevelCompleted { get; set; }
        [ForeignKey("RefIncomeCalculationMethodId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefIncomeCalculationMethod? RefIncomeCalculationMethod { get; set; }
        [ForeignKey("RefProofOfResidencyTypeId")]
        [InverseProperty("PersonFamilies")]
        public virtual RefProofOfResidencyType? RefProofOfResidencyType { get; set; }
    }
}
