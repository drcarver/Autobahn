using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12School()
        {
            K12SchoolCorrectiveAction = new HashSet<K12SchoolCorrectiveAction>();
            K12SchoolGradeLevelsApproved = new HashSet<K12SchoolGradeLevelsApproved>();
            K12SchoolGradeOffered = new HashSet<K12SchoolGradeOffered>();
            K12SchoolImprovement = new HashSet<K12SchoolImprovement>();
            K12SchoolIndicatorStatus = new HashSet<K12SchoolIndicatorStatus>();
            K12SchoolStatus = new HashSet<K12SchoolStatus>();
        }

        public int K12SchoolId { get; set; }

        public int OrganizationId { get; set; }

        public bool? CharterSchoolIndicator { get; set; }

        [StringLength(9)]
        public string CharterSchoolApprovalYear { get; set; }

        [StringLength(300)]
        public string AccreditationAgencyName { get; set; }

        public bool? CharterSchoolOpenEnrollmentIndicator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CharterSchoolContractApprovalDate { get; set; }

        [StringLength(30)]
        public string CharterSchoolContractIdNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CharterSchoolContractRenewalDate { get; set; }

        public int? K12CharterSchoolManagementOrganizationId { get; set; }

        public int? K12CharterSchoolAuthorizerAgencyId { get; set; }

        public int? RefSchoolTypeId { get; set; }

        public int? RefSchoolLevelId { get; set; }

        public int? RefAdministrativeFundingControlId { get; set; }

        public int? RefCharterSchoolTypeId { get; set; }

        public int? RefIncreasedLearningTimeTypeId { get; set; }

        public int? RefStatePovertyDesignationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12CharterSchoolAuthorizerAgency K12CharterSchoolAuthorizerAgency { get; set; }

        public virtual K12CharterSchoolManagementOrganization K12CharterSchoolManagementOrganization { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdministrativeFundingControl RefAdministrativeFundingControl { get; set; }

        public virtual RefCharterSchoolType RefCharterSchoolType { get; set; }

        public virtual RefIncreasedLearningTimeType RefIncreasedLearningTimeType { get; set; }

        public virtual RefSchoolLevel RefSchoolLevel { get; set; }

        public virtual RefSchoolType RefSchoolType { get; set; }

        public virtual RefStatePovertyDesignation RefStatePovertyDesignation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolCorrectiveAction> K12SchoolCorrectiveAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolGradeLevelsApproved> K12SchoolGradeLevelsApproved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolGradeOffered> K12SchoolGradeOffered { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolImprovement> K12SchoolImprovement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolIndicatorStatus> K12SchoolIndicatorStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolStatus> K12SchoolStatus { get; set; }
    }
}
