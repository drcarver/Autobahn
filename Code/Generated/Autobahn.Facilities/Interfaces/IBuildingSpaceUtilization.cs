//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSpaceUtilization.cs
//* Name:       Available Utilized Instructional Space
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IBuildingSpaceUtilization : IAutobahnBase
    {
        /// <summary>
        /// Available Utilized Instructional Space
        /// <para>
        /// An indication that the instruction space in a school is used in the calculation of student capacity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20883">Available Utilized Instructional Space</a>
        /// </para>
        /// </summary>
        System.Boolean? AvailableUtilizedInstructionalSpace { get; set; }

        /// <summary>
        /// Building Capacity Factor Indicator
        /// <para>
        /// A designation as to whether the space is included in the calculation of school building capacity under state or local guidelines.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20884">Building Capacity Factor Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? BuildingCapacityFactorIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IBuildingSpace"/> model
        /// </summary>
        Guid BuildingSpaceId { get; set; }

        /// <summary>
        /// Building Space Utilization Area
        /// <para>
        /// The area in square feet measured between the principal wall that faces at or near floor level, including alcove spaces, and the outer limits of space designed to serve the activity. Structural space is excluded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20842">Building Space Utilization Area</a>
        /// </para>
        /// </summary>
        System.Decimal? BuildingSpaceUtilizationArea { get; set; }

        /// <summary>
        /// Building Unassigned Space Indicator
        /// <para>
        /// An indication that the space in a school, including circulation, administration offices, support spaces, and common areas, is not part of the calculation for capacity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20844">Building Unassigned Space Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? BuildingUnassignedSpaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorType"/> model
        /// </summary>
        Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    }
}
