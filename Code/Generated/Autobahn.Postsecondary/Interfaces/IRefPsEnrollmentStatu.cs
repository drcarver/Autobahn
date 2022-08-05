//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefPsEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefPsEnrollmentStatu Interface
     /// </summary>
    public partial interface IRefPsEnrollmentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPsEnrollmentStatus"/> model
        /// </summary>
        Guid RefPsEnrollmentStatusId { get; set; }

    }
}
