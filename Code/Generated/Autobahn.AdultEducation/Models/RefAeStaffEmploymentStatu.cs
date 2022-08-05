//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeStaffEmploymentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.AdultEducation.Interfaces;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The RefAeStaffEmploymentStatu Model
     /// </summary>
    public partial class RefAeStaffEmploymentStatu : ReferenceModelBase, IRefAeStaffEmploymentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        public Guid RefAeStaffEmploymentStatusId { get; set; }

    }
}
