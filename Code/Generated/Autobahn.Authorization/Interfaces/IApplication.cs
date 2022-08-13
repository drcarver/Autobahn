//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IApplication Interface
     /// </summary>
    public partial interface IApplication : IAutobahnBase
    {
        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        System.String Uri { get; set; }

    }
}
