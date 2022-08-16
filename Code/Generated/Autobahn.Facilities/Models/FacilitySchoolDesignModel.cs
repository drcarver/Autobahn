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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefBuildingSchoolDesignTypeId { get; set; }

    }
}
