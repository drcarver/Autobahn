//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCredential Model
     /// </summary>
    public partial class StaffCredentialModel : AutobahnBase, Interfaces.IStaffCredential
    {
        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

    }
}
