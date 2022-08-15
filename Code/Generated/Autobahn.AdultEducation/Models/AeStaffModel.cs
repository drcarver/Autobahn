//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStaff Model
     /// </summary>
    public partial class AeStaffModel : AutobahnBase, Interfaces.IAeStaff
    {
        /// <summary>
        /// The titles of employment, official status, or rank of adult education staff.
        /// </summary>
        public Guid? RefAeStaffClassificationId { get; set; }

    }
}
