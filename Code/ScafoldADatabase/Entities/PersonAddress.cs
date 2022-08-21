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
    [Table("PersonAddress")]
    public partial class PersonAddress
    {
        public PersonAddress()
        {
            PersonAddressNcesSides = new HashSet<PersonAddressNcesSide>();
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonAddressId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefPersonLocationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(150)]
        public string? StreetNumberAndName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? ApartmentRoomOrSuiteNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? City { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefStateId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(17)]
        public string? PostalCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? AddressCountyName { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int? RefCountyId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCountryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(20)]
        public string? Latitude { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(20)]
        public string? Longitude { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPersonalInformationVerificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DoNotPublishIndicator { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonAddresses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonAddresses")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonAddresses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCountryId")]
        [InverseProperty("PersonAddresses")]
        public virtual RefCountry? RefCountry { get; set; }
        [ForeignKey("RefCountyId")]
        [InverseProperty("PersonAddresses")]
        public virtual RefCounty? RefCounty { get; set; }
        [ForeignKey("RefPersonLocationTypeId")]
        [InverseProperty("PersonAddresses")]
        public virtual RefPersonLocationType RefPersonLocationType { get; set; } = null!;
        [ForeignKey("RefPersonalInformationVerificationId")]
        [InverseProperty("PersonAddresses")]
        public virtual RefPersonalInformationVerification? RefPersonalInformationVerification { get; set; }
        [ForeignKey("RefStateId")]
        [InverseProperty("PersonAddresses")]
        public virtual RefState? RefState { get; set; }
        [InverseProperty("PersonAddress")]
        public virtual ICollection<PersonAddressNcesSide> PersonAddressNcesSides { get; set; }
        [InverseProperty("PersonAddress")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
        [InverseProperty("PersonAddress")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
    }
}
