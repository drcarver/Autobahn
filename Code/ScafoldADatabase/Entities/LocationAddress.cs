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
    [Table("LocationAddress")]
    public partial class LocationAddress
    {
        [Key]
        public int LocationAddressId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int LocationId { get; set; }
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
        [StringLength(60)]
        public string? BuildingSiteNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? City { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(17)]
        public string? PostalCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? CountyName { get; set; }
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
        [StringLength(100)]
        public string? FacilityBlockNumberArea { get; set; }
        [StringLength(100)]
        public string? FacilityCensusTract { get; set; }
        /// <summary>
        /// Surrogate key from RefStateAbbreviation identifying the state.
        /// </summary>
        public int? RefStateId { get; set; }
        /// <summary>
        /// Surrogate key from RefCounty identifying the county code.
        /// </summary>
        public int? RefCountyId { get; set; }
        /// <summary>
        /// Surrogate key from RefCountry identifying the country code.
        /// </summary>
        public int? RefCountryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefERSRuralUrbanContinuumCodeId")]
        public int? RefErsruralUrbanContinuumCodeId { get; set; }
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
        [InverseProperty("LocationAddresses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("LocationAddresses")]
        public virtual Location Location { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LocationAddresses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCountryId")]
        [InverseProperty("LocationAddresses")]
        public virtual RefCountry? RefCountry { get; set; }
        [ForeignKey("RefCountyId")]
        [InverseProperty("LocationAddresses")]
        public virtual RefCounty? RefCounty { get; set; }
        [ForeignKey("RefErsruralUrbanContinuumCodeId")]
        [InverseProperty("LocationAddresses")]
        public virtual RefErsruralUrbanContinuumCode? RefErsruralUrbanContinuumCode { get; set; }
        [ForeignKey("RefStateId")]
        [InverseProperty("LocationAddresses")]
        public virtual RefState? RefState { get; set; }
    }
}
