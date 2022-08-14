//**********************************************************
//* DomainName: Common Models
//* FileName:   RefCourseGpaApplicabilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseGpaApplicability Model
     /// </summary>
    public partial class RefCourseGpaApplicability : ReferenceModelBase, Interfaces.IRefCourseGpaApplicability
    {
        /// <summary>
        /// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
        /// </summary>
        public Guid RefCourseGPAApplicabilityId { get; set; }

    }
}
