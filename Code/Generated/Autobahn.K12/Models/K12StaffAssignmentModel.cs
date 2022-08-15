//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffAssignment Model
     /// </summary>
    public partial class K12StaffAssignmentModel : AutobahnBase, Interfaces.IK12StaffAssignment
    {
        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

    }
}
