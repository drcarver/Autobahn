//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityDesignConstruction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesignConstruction Interface
     /// </summary>
    public partial interface IFacilityDesignConstruction : IAutobahnBase
    {
        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        System.String FacilityAdditionYear { get; set; }

    }
}
