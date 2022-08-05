//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseGpaApplicability.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseGpaApplicability Model
     /// </summary>
    public partial class RefCourseGpaApplicability : ReferenceModelBase, IRefCourseGpaApplicability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid RefCourseGPAApplicabilityId { get; set; }

    }
}
