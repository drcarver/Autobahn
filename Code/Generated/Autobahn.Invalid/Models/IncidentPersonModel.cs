//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentPersonModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IncidentPerson Model
     /// </summary>
    public partial class IncidentPersonModel : AutobahnBase, Interfaces.IIncidentPerson
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Identifier { get; set; }

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
        public  RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentPersonTypeId { get; set; }

    }
}
