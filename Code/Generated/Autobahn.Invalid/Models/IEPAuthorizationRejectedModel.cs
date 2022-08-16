//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationRejectedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IEPAuthorizationRejected Model
     /// </summary>
    public partial class IEPAuthorizationRejectedModel : AutobahnBase, Interfaces.IIEPAuthorizationRejected
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? PortionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PortionExplanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
