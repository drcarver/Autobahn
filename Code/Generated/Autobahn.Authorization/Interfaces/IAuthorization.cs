//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAuthorization Interface
     /// </summary>
    public partial interface IAuthorization : IAutobahnBase
    {
        /// <summary>
        /// The user role for which the person is allowed.
        /// </summary>
        System.String ApplicationRoleName { get; set; }

    }
}
