//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefEnrollmentStatu Interface
     /// </summary>
    public partial interface IRefEnrollmentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        Guid RefEnrollmentStatusId { get; set; }

    }
}
