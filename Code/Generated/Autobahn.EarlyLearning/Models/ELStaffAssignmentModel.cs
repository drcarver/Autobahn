//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffAssignment Model
     /// </summary>
    public partial class ELStaffAssignmentModel : AutobahnBase, Interfaces.IELStaffAssignmentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELStaffAssignment.ItinerantProvider non nullable property
        /// </summary>
        public System.Boolean ItinerantProvider { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
