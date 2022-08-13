//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IDSVersionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
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
