//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddress.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonAddress")]
    public partial class PersonAddress : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonAddress()
        {
            PersonAddressNcesSides = new HashSet<PersonAddressNcesSide>();
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [ForeignKey("RefPersonLocationType")]
        public Guid RefPersonLocationTypeId { get; set; }

        [StringLength(150)]
        public string StreetNumberAndName { get; set; }

        [StringLength(60)]
        public string ApartmentRoomOrSuiteNumber { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [ForeignKey("RefState")]
        public Guid? RefStateId { get; set; }

        [StringLength(17)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string AddressCountyName { get; set; }

        [ForeignKey("RefCounty")]
        public Guid? RefCountyId { get; set; }

        [ForeignKey("RefCountry")]
        public Guid? RefCountryId { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        [ForeignKey("RefPersonalInformationVerification")]
        public Guid? RefPersonalInformationVerificationId { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public virtual Person Person { get; set; }

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
