using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LocationAddress")]
    public partial class LocationAddress
    {
        public int LocationAddressId { get; set; }

        public int LocationId { get; set; }

        [StringLength(150)]
        public string StreetNumberAndName { get; set; }

        [StringLength(60)]
        public string ApartmentRoomOrSuiteNumber { get; set; }

        [StringLength(60)]
        public string BuildingSiteNumber { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(17)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string CountyName { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        [StringLength(100)]
        public string FacilityBlockNumberArea { get; set; }

        [StringLength(100)]
        public string FacilityCensusTract { get; set; }

        public int? RefStateId { get; set; }

        public int? RefCountyId { get; set; }

        public int? RefCountryId { get; set; }

        public int? RefERSRuralUrbanContinuumCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Location Location { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefCounty RefCounty { get; set; }

        public virtual RefERSRuralUrbanContinuumCode RefERSRuralUrbanContinuumCode { get; set; }

        public virtual RefState RefState { get; set; }
    }
}
