//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Authentication Model
     /// </summary>
    public partial class AuthenticationModel : AutobahnBase, Interfaces.IAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? IdentityProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IdentityProviderUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LoginIdentifier { get; set; }

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
        public  StartDate { get; set; }

    }
}
