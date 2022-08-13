//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilitySchoolDesign.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySchoolDesign Interface
     /// </summary>
    public partial interface IFacilitySchoolDesign : IAutobahnBase
    {
        /// <summary>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </summary>
        Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
