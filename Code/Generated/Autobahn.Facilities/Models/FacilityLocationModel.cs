//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLocation Model
     /// </summary>
    public partial class FacilityLocationModel : AutobahnBase, Interfaces.IFacilityLocation
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
