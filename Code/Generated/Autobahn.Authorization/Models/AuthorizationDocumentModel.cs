//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AuthorizationDocument Model
     /// </summary>
    public partial class AuthorizationDocumentModel : AutobahnBase, Interfaces.IAuthorizationDocument
    {
        /// <summary>
        /// 
        /// </summary>
        public  AcceptanceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AuthorizationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DecisionExplanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAuthorizerTypeId { get; set; }

    }
}
