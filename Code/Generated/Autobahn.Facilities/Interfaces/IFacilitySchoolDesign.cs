//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilitySchoolDesign.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySchoolDesign
     /// </summary>
    public partial interface IFacilitySchoolDesign : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
