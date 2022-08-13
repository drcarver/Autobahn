//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPSStudentProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPSStudentProgram Interface
     /// </summary>
    public partial interface IPSStudentProgram : IAutobahnBase
    {
        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid? PsProgramId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid? RefCipUseId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid? RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
