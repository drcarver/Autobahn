using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12CharterSchoolManagementOrganization")]
    public partial class K12CharterSchoolManagementOrganization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12CharterSchoolManagementOrganization()
        {
            K12School = new HashSet<K12School>();
        }

        public int K12CharterSchoolManagementOrganizationId { get; set; }

        public int? OrganizationId { get; set; }

        public int? RefCharterSchoolManagementOrganizationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RefCharterSchoolManagementOrganizationType RefCharterSchoolManagementOrganizationType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12School> K12School { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
