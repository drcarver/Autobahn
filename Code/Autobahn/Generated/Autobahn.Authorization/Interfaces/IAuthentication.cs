//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthentication.cs
//* Name:       Authentication Identity Provider Name
//* Definition: The name of a provider that can authenticate the identity of an person.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The name of a provider that can authenticate the identity of an person.
     /// </summary>
    public partial interface IAuthentication : IAutobahnBase
    {
    }
}
