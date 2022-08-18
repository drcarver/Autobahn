//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOffered Model
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedModel : AutobahnBase, Interfaces.IEarlyChildhoodProgramTypeOffered
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
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunityBasedType"/> model
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodProgramEnrollmentType"/> model
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
