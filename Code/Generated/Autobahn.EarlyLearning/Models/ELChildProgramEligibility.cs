//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildProgramEligibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildProgramEligibility
     /// </summary>
    public partial class ELChildProgramEligibility : AutobahnBase, Interfaces.IELChildProgramEligibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildProgramEligibility.StatusDate nullable property
        /// </summary>
        public System.DateTime? StatusDate { get; set; }

        /// <summary>
        /// Defines the ELChildProgramEligibility.ExpirationDate nullable property
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityStatus"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}