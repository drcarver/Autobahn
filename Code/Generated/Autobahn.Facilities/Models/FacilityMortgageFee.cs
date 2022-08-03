//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageFee.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgageFee
     /// </summary>
    public partial class FacilityMortgageFee : IFacilityMortgageFee
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgageFee.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityMortgageFee.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
