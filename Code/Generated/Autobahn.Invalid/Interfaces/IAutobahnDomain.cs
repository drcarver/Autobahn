//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahnDomain.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahnDomain Interface
     /// </summary>
    public partial interface IAutobahnDomain : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Name { get; set; }

    }
}