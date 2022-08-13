//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PSStudentProgram Model
     /// </summary>
    public partial class PSStudentProgramModel : AutobahnBase, Interfaces.IPSStudentProgram
    {
        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid? PsProgramId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid? RefCipUseId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
