//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacility Interface
     /// </summary>
    public partial interface IFacility : IAutobahnBase
    {
        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingArea { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingName { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingNumberOfStories { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingYearBuilt { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.DateTime? FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String FacilityExpectedLife { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.Boolean? FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? RefCampusStatusId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        Guid? RefCampusTypeId { get; set; }

    }
}
