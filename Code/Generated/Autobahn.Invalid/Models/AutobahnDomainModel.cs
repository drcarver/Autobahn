//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnDomainModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The AutobahnDomain Model
     /// </summary>
    public partial class AutobahnDomainModel : AutobahnBase, Interfaces.IAutobahnDomain
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String Module { get; set; }

    }
}
