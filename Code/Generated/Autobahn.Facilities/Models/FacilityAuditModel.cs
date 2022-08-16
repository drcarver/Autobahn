//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityAudit Model
     /// </summary>
    public partial class FacilityAuditModel : AutobahnBase, Interfaces.IFacilityAudit
    {
        /// <summary>
        /// 
        /// </summary>
        public  FacilityAuditDate { get; set; }

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
        public Guid? RefFacilityAuditTypeId { get; set; }

    }
}
