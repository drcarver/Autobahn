//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodProgramTypeOffered.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOffered
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOffered : AutobahnBase, Interfaces.IEarlyChildhoodProgramTypeOffered
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramEnrollmentType"/> model
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

        /// <summary>
        /// Defines the EarlyChildhoodProgramTypeOffered.InclusiveSettingIndicator nullable property
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunityBasedType"/> model
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
