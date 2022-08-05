//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherPrepEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTeacherPrepEnrollmentStatu Model
     /// </summary>
    public partial class RefTeacherPrepEnrollmentStatu : ReferenceModelBase, IRefTeacherPrepEnrollmentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        public Guid RefTeacherPrepEnrollmentStatusId { get; set; }

    }
}
