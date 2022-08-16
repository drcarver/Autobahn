//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorizationDocument.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAuthorizationDocument Interface
     /// </summary>
    public partial interface IAuthorizationDocument : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AcceptanceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AuthorizationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DecisionExplanation { get; set; }

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
        Guid? RefAuthorizerTypeId { get; set; }

    }
}
