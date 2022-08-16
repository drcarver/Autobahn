//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse Model
     /// </summary>
    public partial class CredentialCriteriaCourseModel : AutobahnBase, Interfaces.ICredentialCriteriaCourse
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
