//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityMortgageFee.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgageFee
     /// </summary>
    public partial interface IFacilityMortgageFee
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// </summary>
        Guid RefFacilityFinancingFeeTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgageFee.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityMortgageFee.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
