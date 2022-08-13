//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffAssignment Model
     /// </summary>
    public partial class ELStaffAssignmentModel : AutobahnBase, Interfaces.IELStaffAssignment
    {
        /// <summary>
        /// An indication of whether a person provides services at more than one site.
        /// </summary>
        public System.Boolean ItinerantProvider { get; set; }

        /// <summary>
        /// An indication of whether a person provides services at more than one site.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
