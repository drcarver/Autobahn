//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTeacherPrepEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTeacherPrepEnrollmentStatu Interface
     /// </summary>
    public partial interface IRefTeacherPrepEnrollmentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        Guid RefTeacherPrepEnrollmentStatusId { get; set; }

    }
}
