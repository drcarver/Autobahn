//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponentService Model
     /// </summary>
    public partial class BuildingSystemComponentServiceModel : AutobahnBase, Interfaces.IBuildingSystemComponentService
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
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Component or Fixture Scheduled Serviced Date
        /// <para>
        /// The month, day, and year a major component, system, equipment, or fixture is scheduled to be serviced for preventive or routine maintenance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20881">Component or Fixture Scheduled Serviced Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// Component or Fixture Serviced Date
        /// <para>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20880">Component or Fixture Serviced Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ComponentOrFixtureServicedDate { get; set; }

    }
}
