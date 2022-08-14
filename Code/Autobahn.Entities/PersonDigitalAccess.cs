using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDigitalAccess")]
    public partial class PersonDigitalAccess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDigitalAccess()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        public int PersonDigitalAccessId { get; set; }

        public int PersonId { get; set; }

        public bool? InternetAccessInResidence { get; set; }

        public int? PersonAddressId { get; set; }

        public int? RefBarrierToInternetAccessInResidenceId { get; set; }

        public int? RefInternetAccessTypeInResidenceId { get; set; }

        public int? RefInternetPerformanceInResidenceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBarrierToInternetAccessInResidence RefBarrierToInternetAccessInResidence { get; set; }

        public virtual RefInternetAccessTypeInResidence RefInternetAccessTypeInResidence { get; set; }

        public virtual RefInternetPerformanceInResidence RefInternetPerformanceInResidence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
    }
}
