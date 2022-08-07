//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffAssignmentModel Interface
     /// </summary>
    public partial interface IELStaffAssignmentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELStaffAssignment.ItinerantProvider non nullable property
        /// </summary>
        System.Boolean ItinerantProvider { get; set; }

    }
}
