//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCredential Model
     /// </summary>
    public partial class PersonCredentialModel : AutobahnBase, Interfaces.IPersonCredential
    {
        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

    }
}
