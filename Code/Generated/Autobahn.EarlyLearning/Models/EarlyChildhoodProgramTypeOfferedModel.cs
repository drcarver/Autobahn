//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedModel.cs
//***************************************************************************

using Autobahn.Interfaces.EarlyLearning;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOffered Model
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedModel : AutobahnBase, IEarlyChildhoodProgramTypeOffered
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
        public Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Community-based Type
        /// <para>
        /// Non domestic residence in which the early learning setting is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// Early Childhood Program Enrollment Type
        /// <para>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
        /// </para>
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
