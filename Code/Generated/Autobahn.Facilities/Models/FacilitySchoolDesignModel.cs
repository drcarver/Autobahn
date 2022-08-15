//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySchoolDesign Model
     /// </summary>
    public partial class FacilitySchoolDesignModel : AutobahnBase, Interfaces.IFacilitySchoolDesign
    {
        /// <summary>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
