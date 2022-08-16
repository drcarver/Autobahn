//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemComponentService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponentService Interface
     /// </summary>
    public partial interface IBuildingSystemComponentService : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ComponentOrFixtureServicedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
