//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahnElement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahnElement Interface
     /// </summary>
    public partial interface IAutobahnElement : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Id { get; set; }

    }
}
