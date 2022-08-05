//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PSStudentProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PSStudentProgram
     /// </summary>
    public partial class PSStudentProgram : AutobahnBase, Interfaces.IPSStudentProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// </summary>
        public Guid? RefCipUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsProgram"/> model
        /// </summary>
        public Guid? PsProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
