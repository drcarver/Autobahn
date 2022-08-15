//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnTableModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The AutobahnTable Model
     /// </summary>
    public partial class AutobahnTableModel : AutobahnBase, Interfaces.IAutobahnTable
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Id { get; set; }

    }
}
