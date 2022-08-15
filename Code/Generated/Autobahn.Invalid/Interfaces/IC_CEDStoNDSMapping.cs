//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IC_CEDStoNDSMapping.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IC_CEDStoNDSMapping Interface
     /// </summary>
    public partial interface IC_CEDStoNDSMapping : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.String GlobalID { get; set; }

    }
}
