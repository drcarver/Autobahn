//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagement Model
     /// </summary>
    public partial class FacilityManagementModel : AutobahnBase, Interfaces.IFacilityManagement
    {
        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

    }
}
