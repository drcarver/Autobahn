//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IEarlyChildhoodProgramTypeOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IEarlyChildhoodProgramTypeOffered Interface
     /// </summary>
    public partial interface IEarlyChildhoodProgramTypeOffered : IAutobahnBase
    {
        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
