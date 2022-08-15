//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemCategory Interface
     /// </summary>
    public partial interface IBuildingSystemCategory : IAutobahnBase
    {
        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

    }
}
