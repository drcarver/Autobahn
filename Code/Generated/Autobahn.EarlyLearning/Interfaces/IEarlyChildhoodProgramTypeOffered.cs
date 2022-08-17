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
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCommunityBasedType"/> model
        /// </summary>
        Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEarlyChildhoodProgramEnrollmentType"/> model
        /// </summary>
        Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
