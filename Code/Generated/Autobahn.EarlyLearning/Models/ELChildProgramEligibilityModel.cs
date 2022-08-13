//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildProgramEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildProgramEligibility Model
     /// </summary>
    public partial class ELChildProgramEligibilityModel : AutobahnBase, Interfaces.IELChildProgramEligibility
    {
        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public System.DateTime? StatusDate { get; set; }

    }
}
