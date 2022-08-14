using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12Lea")]
    public partial class K12Lea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12Lea()
        {
            K12LeaFederalReporting = new HashSet<K12LeaFederalReporting>();
            K12LeaGradeLevelsApproved = new HashSet<K12LeaGradeLevelsApproved>();
            K12LeaGradeOffered = new HashSet<K12LeaGradeOffered>();
            K12LeaPreKEligibility = new HashSet<K12LeaPreKEligibility>();
            K12LeaPreKEligibleAgesIDEA = new HashSet<K12LeaPreKEligibleAgesIDEA>();
            K12LeaSafeDrugFree = new HashSet<K12LeaSafeDrugFree>();
            K12LeaTitleIIIProfessionalDevelopment = new HashSet<K12LeaTitleIIIProfessionalDevelopment>();
            K12LeaTitleISupportService = new HashSet<K12LeaTitleISupportService>();
        }

        public int K12LeaId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(3)]
        public string SupervisoryUnionIdentificationNumber { get; set; }

        public bool? CharterSchoolIndicator { get; set; }

        public int? RefLeaTypeId { get; set; }

        public int? RefLeaImprovementStatusId { get; set; }

        public int? RefPublicSchoolChoiceStatusId { get; set; }

        public int? RefCharterLeaStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCharterLeaStatus RefCharterLeaStatus { get; set; }

        public virtual RefLeaImprovementStatus RefLeaImprovementStatus { get; set; }

        public virtual RefLeaType RefLeaType { get; set; }

        public virtual RefPublicSchoolChoiceStatus RefPublicSchoolChoiceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaFederalReporting> K12LeaFederalReporting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaGradeLevelsApproved> K12LeaGradeLevelsApproved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaGradeOffered> K12LeaGradeOffered { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaPreKEligibility> K12LeaPreKEligibility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaPreKEligibleAgesIDEA> K12LeaPreKEligibleAgesIDEA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaSafeDrugFree> K12LeaSafeDrugFree { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaTitleIIIProfessionalDevelopment> K12LeaTitleIIIProfessionalDevelopment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaTitleISupportService> K12LeaTitleISupportService { get; set; }
    }
}
