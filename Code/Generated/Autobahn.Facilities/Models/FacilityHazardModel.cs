//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityHazard Model
     /// </summary>
    public partial class FacilityHazardModel : AutobahnBase, Interfaces.IFacilityHazard
    {
        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.String FacilityLocationOfHazardousMaterials { get; set; }

    }
}
