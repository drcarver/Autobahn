//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsEnrollmentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefPsEnrollmentStatu Model
     /// </summary>
    public partial class RefPsEnrollmentStatu : ReferenceModelBase, IRefPsEnrollmentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPsEnrollmentStatus"/> model
        /// </summary>
        public Guid RefPsEnrollmentStatusId { get; set; }

    }
}
