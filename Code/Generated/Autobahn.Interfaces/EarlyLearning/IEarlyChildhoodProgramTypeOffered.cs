//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IEarlyChildhoodProgramTypeOffered.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.EarlyLearning
{
     /// <summary>
     /// The IEarlyChildhoodProgramTypeOffered Interface
     /// </summary>
    public partial interface IEarlyChildhoodProgramTypeOffered : IAutobahnBase
    {
        /// <summary>
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Community-based Type
        /// <para>
        /// Non domestic residence in which the early learning setting is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
        /// </para>
        /// </summary>
        Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// Early Childhood Program Enrollment Type
        /// <para>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
        /// </para>
        /// </summary>
        Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
