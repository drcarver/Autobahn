//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceModel.cs
//**********************************************************

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
        /// 
        /// </summary>
        public  ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ComponentOrFixtureServicedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
