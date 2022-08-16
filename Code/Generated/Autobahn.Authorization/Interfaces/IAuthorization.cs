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
        /// 
        /// </summary>
        Guid? ApplicationRoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

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
