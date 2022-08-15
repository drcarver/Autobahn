//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityHazard.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityHazard Interface
     /// </summary>
    public partial interface IFacilityHazard : IAutobahnBase
    {
        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        System.String FacilityLocationOfHazardousMaterials { get; set; }

    }
}
