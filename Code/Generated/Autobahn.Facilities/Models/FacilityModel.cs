//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The Facility Model
     /// </summary>
    public partial class FacilityModel : AutobahnBase, Interfaces.IFacility
    {
        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingArea { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingName { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingNumberOfStories { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingYearBuilt { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.DateTime? FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String FacilityExpectedLife { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.Boolean? FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? RefCampusStatusId { get; set; }

        /// <summary>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </summary>
        public Guid? RefCampusTypeId { get; set; }

    }
}
