//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorizationDocument.cs
//* Name:       Authorizer Type
//* Definition: Type of person who authorized the decision or document.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// Type of person who authorized the decision or document.
     /// </summary>
    public partial interface IAuthorizationDocument : IAutobahnBase
    {
    }
}
