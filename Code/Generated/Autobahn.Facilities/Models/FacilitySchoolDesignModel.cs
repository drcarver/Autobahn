//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesignModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySchoolDesign Model
     /// </summary>
    public partial class FacilitySchoolDesignModel : AutobahnBase, Interfaces.IFacilitySchoolDesignModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
