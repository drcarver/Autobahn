//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySite Model
     /// </summary>
    public partial class FacilitySiteModel : AutobahnBase, Interfaces.IFacilitySite
    {
        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        public System.Decimal? FacilitySiteArea { get; set; }

    }
}
