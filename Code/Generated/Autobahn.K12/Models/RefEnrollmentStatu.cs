//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefEnrollmentStatu Model
     /// </summary>
    public partial class RefEnrollmentStatu : ReferenceModelBase, IRefEnrollmentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        public Guid RefEnrollmentStatusId { get; set; }

    }
}
