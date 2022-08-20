//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationAddress.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("LocationAddress", Schema = "Common")]
    public partial class LocationAddress : EntityBase
    {
        [ForeignKey("Location")]
        public Guid LocationId { get; set; }

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

        [ForeignKey("RefState")]
        public Guid? RefStateId { get; set; }

        [ForeignKey("RefCounty")]
        public Guid? RefCountyId { get; set; }

        [ForeignKey("RefCountry")]
        public Guid? RefCountryId { get; set; }

        [ForeignKey("RefERSRuralUrbanContinuumCode")]
        public Guid? RefERSRuralUrbanContinuumCodeId { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public virtual Location Location { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefCounty RefCounty { get; set; }

        public virtual RefERSRuralUrbanContinuumCode RefERSRuralUrbanContinuumCode { get; set; }

        public virtual RefState RefState { get; set; }
    }
}
