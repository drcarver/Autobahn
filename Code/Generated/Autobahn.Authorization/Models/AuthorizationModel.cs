//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Authorization Model
     /// </summary>
    public partial class AuthorizationModel : AutobahnBase, Interfaces.IAuthorization
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ApplicationRoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

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
