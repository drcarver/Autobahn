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
    [Table("K12School", Schema ="K12")]
    public partial class K12School
    {
        public K12School()
        {
            K12SchoolCorrectiveActions = new HashSet<K12SchoolCorrectiveAction>();
            K12schoolGradeLevelsApproveds = new HashSet<K12SchoolGradeLevelsApproved>();
            K12schoolGradeOffereds = new HashSet<K12SchoolGradeOffered>();
            K12schoolImprovements = new HashSet<K12SchoolImprovement>();
            K12schoolIndicatorStatuses = new HashSet<K12SchoolIndicatorStatus>();
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int K12SchoolId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CharterSchoolIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(9)]
        public string? CharterSchoolApprovalYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? AccreditationAgencyName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CharterSchoolOpenEnrollmentIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CharterSchoolContractApprovalDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? CharterSchoolContractIdNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CharterSchoolContractRenewalDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? K12CharterSchoolManagementOrganizationId { get; set; }
        public int? K12CharterSchoolAuthorizerAgencyId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSchoolTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSchoolLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdministrativeFundingControlId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCharterSchoolTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncreasedLearningTimeTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefStatePovertyDesignationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12schools")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12charterSchoolAuthorizerAgencyId")]
        [InverseProperty("K12schools")]
        public virtual K12CharterSchoolAuthorizerAgency? K12charterSchoolAuthorizerAgency { get; set; }
        [ForeignKey("K12charterSchoolManagementOrganizationId")]
        [InverseProperty("K12schools")]
        public virtual K12CharterSchoolManagementOrganization? K12charterSchoolManagementOrganization { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12schools")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schools")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdministrativeFundingControlId")]
        [InverseProperty("K12schools")]
        public virtual RefAdministrativeFundingControl? RefAdministrativeFundingControl { get; set; }
        [ForeignKey("RefCharterSchoolTypeId")]
        [InverseProperty("K12schools")]
        public virtual RefCharterSchoolType? RefCharterSchoolType { get; set; }
        [ForeignKey("RefIncreasedLearningTimeTypeId")]
        [InverseProperty("K12schools")]
        public virtual RefIncreasedLearningTimeType? RefIncreasedLearningTimeType { get; set; }
        [ForeignKey("RefSchoolLevelId")]
        [InverseProperty("K12schools")]
        public virtual RefSchoolLevel? RefSchoolLevel { get; set; }
        [ForeignKey("RefSchoolTypeId")]
        [InverseProperty("K12schools")]
        public virtual RefSchoolType? RefSchoolType { get; set; }
        [ForeignKey("RefStatePovertyDesignationId")]
        [InverseProperty("K12schools")]
        public virtual RefStatePovertyDesignation? RefStatePovertyDesignation { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolCorrectiveAction> K12SchoolCorrectiveActions { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolGradeLevelsApproved> K12schoolGradeLevelsApproveds { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolGradeOffered> K12schoolGradeOffereds { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolImprovement> K12schoolImprovements { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolIndicatorStatus> K12schoolIndicatorStatuses { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
    }
}
