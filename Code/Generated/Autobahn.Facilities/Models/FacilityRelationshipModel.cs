//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityRelationship Model
     /// </summary>
    public partial class FacilityRelationshipModel : AutobahnBase, Interfaces.IFacilityRelationship
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
