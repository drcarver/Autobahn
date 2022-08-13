//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildProgramEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildProgramEligibility Interface
     /// </summary>
    public partial interface IELChildProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        Guid? RefELProgramEligibilityStatusId { get; set; }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        System.DateTime? StatusDate { get; set; }

    }
}
