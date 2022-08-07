//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilitySchoolDesignModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySchoolDesignModel Interface
     /// </summary>
    public partial interface IFacilitySchoolDesignModel : IAutobahnBase
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
