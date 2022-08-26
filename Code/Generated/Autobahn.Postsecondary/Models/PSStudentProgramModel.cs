//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsstudentProgramModel.cs
//***************************************************************************

using Autobahn.Interfaces.Postsecondary;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsstudentProgram Model
     /// </summary>
    public partial class PsstudentProgramModel : AutobahnBase, IPsstudentProgram
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsProgram"/> model
        /// </summary>
        public Guid? PsProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// </summary>
        public Guid? RefCipUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
