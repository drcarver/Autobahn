//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationModel.cs
//* Name:       Building Hours of Public Use Per Week
//* Definition: The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
     /// </summary>
    public partial class FacilityUtilizationModel : AutobahnBase, Interfaces.IFacilityUtilization
    {
        /// <summary>
        /// Building Hours of Public Use Per Week
        /// <para>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20837">Building Hours of Public Use Per Week</a>
        /// </para>
        /// </summary>
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

        /// <summary>
        /// Building Net Area of Instructional Space
        /// <para>
        /// The area of space directly used for instruction excluding circulation, administration, student services, and building support.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20838">Building Net Area of Instructional Space</a>
        /// </para>
        /// </summary>
        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get; set; }

        /// <summary>
        /// Building Number of Teaching Stations
        /// <para>
        /// The number of teaching stations, as defined by how many spaces have, or could have, a teacher assigned to them for classroom instruction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20839">Building Number of Teaching Stations</a>
        /// </para>
        /// </summary>
        public System.Int32? BuildingNumberOfTeachingStations { get; set; }

        /// <summary>
        /// Building Public Use Policy Description
        /// <para>
        /// A description of the policy that enables the community or other organizations to use all or part of a building for purposes other than general education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20840">Building Public Use Policy Description</a>
        /// </para>
        /// </summary>
        public System.String BuildingPublicUsePolicyDescription { get; set; }

        /// <summary>
        /// Facility Enrollment Capacity
        /// <para>
        /// The maximum number of age appropriate students who can be enrolled in a facility such that the district's programmatic, operational, and student/teacher work load requirements are met.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20885">Facility Enrollment Capacity</a>
        /// </para>
        /// </summary>
        public System.Int32? FacilityEnrollmentCapacity { get; set; }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        public Guid FacilityId { get; set; }

    }
}
