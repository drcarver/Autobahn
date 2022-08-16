//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorizationRejected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected Interface
     /// </summary>
    public partial interface IIEPAuthorizationRejected : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? PortionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PortionExplanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
