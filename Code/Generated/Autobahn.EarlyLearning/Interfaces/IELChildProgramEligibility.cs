//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildProgramEligibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildProgramEligibility
     /// </summary>
    public partial interface IELChildProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildProgramEligibility.StatusDate nullable property
        /// </summary>
        System.DateTime? StatusDate { get; set; }

        /// <summary>
        /// Defines the ELChildProgramEligibility.ExpirationDate nullable property
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityStatus"/> model
        /// </summary>
        Guid? RefELProgramEligibilityStatusId { get; set; }

    }
}
