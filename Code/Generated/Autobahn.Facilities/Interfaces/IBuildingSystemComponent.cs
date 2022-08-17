//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemComponent.cs
//* Name:       Building Institutional Equipment Description
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IBuildingSystemComponent : IAutobahnBase
    {
        /// <summary>
        /// Building Institutional Equipment Description
        /// <para>
        /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
        /// </para>
        /// </summary>
        System.String BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// Component or Fixture Useful Life
        /// <para>
        /// The anticipated time (in years) from the time of installation or service that a properly maintained system, component, equipment, or fixture is expected to operate effectively and efficiently.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20882">Component or Fixture Useful Life</a>
        /// </para>
        /// </summary>
        System.Int32? ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Component Identification Code
        /// <para>
        /// A unique number or alphanumeric code assigned to a component by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20821">Facility Component Identification Code</a>
        /// </para>
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Installation Date
        /// <para>
        /// The year in which the system, component, equipment, or fixture was originally installed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20829">Installation Date</a>
        /// </para>
        /// </summary>
        System.String InstallationDate { get; set; }

        /// <summary>
        /// Life-cycle Cost
        /// <para>
        /// The total cost of acquiring, owning, operating, and disposing of a building, facility, or piece of equipment over its useful life.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20830">Life-cycle Cost</a>
        /// </para>
        /// </summary>
        System.Decimal? LifecycleCost { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityFurnishingsType"/> model
        /// </summary>
        Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilitySystemOrComponentCondition"/> model
        /// </summary>
        Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
