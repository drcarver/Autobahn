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
    [Table("K12School")]
    public partial class K12school
    {
        public K12school()
        {
            K12schoolCorrectiveActions = new HashSet<K12schoolCorrectiveAction>();
            K12schoolGradeLevelsApproveds = new HashSet<K12schoolGradeLevelsApproved>();
            K12schoolGradeOffereds = new HashSet<K12schoolGradeOffered>();
            K12schoolImprovements = new HashSet<K12schoolImprovement>();
            K12schoolIndicatorStatuses = new HashSet<K12schoolIndicatorStatus>();
            K12schoolStatuses = new HashSet<K12schoolStatus>();
        }

        [Key]
        [Column("K12SchoolId")]
        public int K12schoolId { get; set; }
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
        [Column("K12CharterSchoolManagementOrganizationId")]
        public int? K12charterSchoolManagementOrganizationId { get; set; }
        [Column("K12CharterSchoolAuthorizerAgencyId")]
        public int? K12charterSchoolAuthorizerAgencyId { get; set; }
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
        public virtual K12charterSchoolAuthorizerAgency? K12charterSchoolAuthorizerAgency { get; set; }
        [ForeignKey("K12charterSchoolManagementOrganizationId")]
        [InverseProperty("K12schools")]
        public virtual K12charterSchoolManagementOrganization? K12charterSchoolManagementOrganization { get; set; }
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
        public virtual ICollection<K12schoolCorrectiveAction> K12schoolCorrectiveActions { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12schoolGradeLevelsApproved> K12schoolGradeLevelsApproveds { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12schoolGradeOffered> K12schoolGradeOffereds { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12schoolImprovement> K12schoolImprovements { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12schoolIndicatorStatus> K12schoolIndicatorStatuses { get; set; }
        [InverseProperty("K12school")]
        public virtual ICollection<K12schoolStatus> K12schoolStatuses { get; set; }
    }
}
