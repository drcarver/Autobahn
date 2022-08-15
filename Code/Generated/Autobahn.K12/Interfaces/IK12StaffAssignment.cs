//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffAssignment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffAssignment Interface
     /// </summary>
    public partial interface IK12StaffAssignment : IAutobahnBase
    {
        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

    }
}
