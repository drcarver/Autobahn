//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityUtilization Model
     /// </summary>
    public partial class FacilityUtilizationModel : AutobahnBase, Interfaces.IFacilityUtilization
    {
        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

    }
}
