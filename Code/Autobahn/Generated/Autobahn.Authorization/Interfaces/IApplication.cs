//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IApplication.cs
//* Name:       Authorization Application Name
//* Definition: The name of a data system or application which an authenticated person may access.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The name of a data system or application which an authenticated person may access.
     /// </summary>
    public partial interface IApplication : IAutobahnBase
    {
    }
}
