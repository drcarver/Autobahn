//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefCourseGpaApplicability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefCourseGpaApplicability Interface
     /// </summary>
    public partial interface IRefCourseGpaApplicability : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid RefCourseGPAApplicabilityId { get; set; }

    }
}
