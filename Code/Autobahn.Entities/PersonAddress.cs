using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonAddress")]
    public partial class PersonAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonAddress()
        {
            PersonAddressNcesSides = new HashSet<PersonAddressNcesSide>();
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        public int PersonAddressId { get; set; }

        public int PersonId { get; set; }

        public int RefPersonLocationTypeId { get; set; }

        [StringLength(150)]
        public string StreetNumberAndName { get; set; }

        [StringLength(60)]
        public string ApartmentRoomOrSuiteNumber { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        public int? RefStateId { get; set; }

        [StringLength(17)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string AddressCountyName { get; set; }

        public int? RefCountyId { get; set; }

        public int? RefCountryId { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        public int? RefPersonalInformationVerificationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefCounty RefCounty { get; set; }

        public virtual RefPersonalInformationVerification RefPersonalInformationVerification { get; set; }

        public virtual RefPersonLocationType RefPersonLocationType { get; set; }

        public virtual RefState RefState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonAddressNcesSide> PersonAddressNcesSides { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
    }
}
