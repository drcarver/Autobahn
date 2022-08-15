//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemComponent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponent Interface
     /// </summary>
    public partial interface IBuildingSystemComponent : IAutobahnBase
    {
        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
