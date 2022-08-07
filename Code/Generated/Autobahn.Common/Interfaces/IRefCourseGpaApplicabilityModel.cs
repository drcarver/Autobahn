//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefCourseGpaApplicabilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefCourseGpaApplicability Interface Model
     /// </summary>
    public partial interface IRefCourseGpaApplicabilityModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid RefCourseGPAApplicabilityId { get; set; }

    }
}
