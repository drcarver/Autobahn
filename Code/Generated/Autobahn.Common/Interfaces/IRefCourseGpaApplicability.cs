//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefCourseGpaApplicability.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefCourseGpaApplicability Interface Model
     /// </summary>
    public partial interface IRefCourseGpaApplicability : IReferenceModel
    {
        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        Guid RefCourseGPAApplicabilityId { get; set; }

    }
}
