//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIDSVersion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIDSVersion Interface
     /// </summary>
    public partial interface IIDSVersion : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.Boolean CurrentVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.DateTime IDSVersionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String IDSVersionNumber { get; set; }

    }
}
