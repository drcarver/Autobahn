//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthentication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAuthentication Interface
     /// </summary>
    public partial interface IAuthentication : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? IdentityProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IdentityProviderUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LoginIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartDate { get; set; }

    }
}
