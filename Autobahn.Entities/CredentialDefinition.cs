using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefinition")]
    public partial class CredentialDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialDefinition()
        {
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialDefAgentCredentials = new HashSet<CredentialDefAgentCredential>();
            CredentialDefCategories = new HashSet<CredentialDefCategory>();
            CredentialDefCriterias = new HashSet<CredentialDefCriteria>();
            CredentialDefIdentifiers = new HashSet<CredentialDefIdentifier>();
            CredentialOffereds = new HashSet<CredentialOffered>();
        }

        public int CredentialDefinitionId { get; set; }

        [StringLength(300)]
        public string AlternateName { get; set; }

        [StringLength(6)]
        public string CredentialNAICSIndustryType { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(6)]
        public string EmploymentNAICSCode { get; set; }

        [StringLength(512)]
        public string ImageUrl { get; set; }

        [StringLength(2000)]
        public string JurisdictionRegion { get; set; }

        [StringLength(2000)]
        public string JurisdictionRegionException { get; set; }

        public string Keywords { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public string ValidationMethodDescription { get; set; }

        public decimal? Version { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CredentialDefDateEffective { get; set; }

        public int? RefCareerClusterId { get; set; }

        public int? RefCipCodeId { get; set; }

        public int? RefCredentialDefIntendedPurposeTypeId { get; set; }

        public int? RefCredentialDefStatusTypeId { get; set; }

        public int? RefCredentialDefVerificationTypeId { get; set; }

        public int? RefONETSOCOccupationTypeId { get; set; }

        public int? RefCTDLAudienceLevelTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? CredentialDefinitionTerminalDegreeIndicator { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefCategory> CredentialDefCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefCriteria> CredentialDefCriterias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefIdentifier> CredentialDefIdentifiers { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCareerCluster RefCareerCluster { get; set; }

        public virtual RefCipCode RefCipCode { get; set; }

        public virtual RefCredentialDefIntendedPurposeType RefCredentialDefIntendedPurposeType { get; set; }

        public virtual RefCredentialDefStatusType RefCredentialDefStatusType { get; set; }

        public virtual RefCredentialDefVerificationType RefCredentialDefVerificationType { get; set; }

        public virtual RefCTDLAudienceLevelType RefCTDLAudienceLevelType { get; set; }

        public virtual RefONETSOCOccupationType RefONETSOCOccupationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialOffered> CredentialOffereds { get; set; }
    }
}
