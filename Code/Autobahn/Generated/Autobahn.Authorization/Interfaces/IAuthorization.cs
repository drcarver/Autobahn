//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorization.cs
//* Name:       Authorization Application Role Name
//* Definition: The user role for which the person is allowed.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The user role for which the person is allowed.
     /// </summary>
    public partial interface IAuthorization : IAutobahnBase
    {
    }
}
