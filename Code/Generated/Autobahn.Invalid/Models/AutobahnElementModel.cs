//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnElementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The AutobahnElement Model
     /// </summary>
    public partial class AutobahnElementModel : AutobahnBase, Interfaces.IAutobahnElement
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Id { get; set; }

    }
}
