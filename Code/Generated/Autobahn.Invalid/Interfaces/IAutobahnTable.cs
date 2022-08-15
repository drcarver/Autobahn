//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahnTable.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahnTable Interface
     /// </summary>
    public partial interface IAutobahnTable : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Id { get; set; }

    }
}
