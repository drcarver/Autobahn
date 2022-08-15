//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSpace.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpace Interface
     /// </summary>
    public partial interface IBuildingSpace : IAutobahnBase
    {
        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        System.String SpaceDescription { get; set; }

    }
}
