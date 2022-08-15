//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStaffEmployment Model
     /// </summary>
    public partial class PsStaffEmploymentModel : AutobahnBase, Interfaces.IPsStaffEmployment
    {
        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

    }
}
