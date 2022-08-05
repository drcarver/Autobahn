//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPSStudentProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPSStudentProgram
     /// </summary>
    public partial interface IPSStudentProgram : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// </summary>
        Guid? RefCipUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsProgram"/> model
        /// </summary>
        Guid? PsProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
        /// </summary>
        Guid? RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

    }
}
