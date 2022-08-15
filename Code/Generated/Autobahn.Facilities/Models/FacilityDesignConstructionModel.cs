//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesignConstruction Model
     /// </summary>
    public partial class FacilityDesignConstructionModel : AutobahnBase, Interfaces.IFacilityDesignConstruction
    {
        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String FacilityAdditionYear { get; set; }

    }
}
