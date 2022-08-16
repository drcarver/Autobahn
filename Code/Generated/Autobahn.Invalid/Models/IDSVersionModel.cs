//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IDSVersionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IDSVersion Model
     /// </summary>
    public partial class IDSVersionModel : AutobahnBase, Interfaces.IIDSVersion
    {
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean CurrentVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime IDSVersionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String IDSVersionNumber { get; set; }

    }
}
