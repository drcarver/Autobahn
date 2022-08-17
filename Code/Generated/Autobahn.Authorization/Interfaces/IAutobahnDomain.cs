//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAutobahnDomain.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAutobahnDomain Interface
     /// </summary>
    public partial interface IAutobahnDomain : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        Guid? Id { get; set; }

        System.String Module { get; set; }

        System.String Name { get; set; }

    }
}
