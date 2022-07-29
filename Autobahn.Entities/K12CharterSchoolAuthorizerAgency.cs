using System;
using System.Collections.Generic;

namespace Autobahn.Entities
{
    public partial class K12CharterSchoolAuthorizerAgency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12CharterSchoolAuthorizerAgency()
        {
            K12School = new HashSet<K12School>();
        }

        public int K12CharterSchoolAuthorizerAgencyId { get; set; }

        public int? OrganizationId { get; set; }

        public int RefCharterSchoolAuthorizerTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCharterSchoolAuthorizerType RefCharterSchoolAuthorizerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12School> K12School { get; set; }
    }
}
