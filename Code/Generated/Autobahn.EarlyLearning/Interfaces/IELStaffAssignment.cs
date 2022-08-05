//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaffAssignment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffAssignment
     /// </summary>
    public partial interface IELStaffAssignment : IAutobahnBase
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
