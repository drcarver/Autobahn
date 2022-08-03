//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityFinancial.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinancial
     /// </summary>
    public partial interface IFacilityFinancial
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityLease"/> model
        /// </summary>
        Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageFee"/> model
        /// </summary>
        Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// Defines the FacilityFinancial.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityFinancial.RecordEndDateTime nullable property
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
