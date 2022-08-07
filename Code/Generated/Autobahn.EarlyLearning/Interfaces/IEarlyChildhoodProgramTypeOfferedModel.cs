//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IEarlyChildhoodProgramTypeOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IEarlyChildhoodProgramTypeOfferedModel Interface
     /// </summary>
    public partial interface IEarlyChildhoodProgramTypeOfferedModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramEnrollmentType"/> model
        /// </summary>
        Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

        /// <summary>
        /// Defines the EarlyChildhoodProgramTypeOffered.InclusiveSettingIndicator nullable property
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunityBasedType"/> model
        /// </summary>
        Guid? RefCommunityBasedTypeId { get; set; }

    }
}
