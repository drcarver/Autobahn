//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolImprovementModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolImprovement Model
     /// </summary>
    public partial class K12SchoolImprovementModel : AutobahnBase, Interfaces.IK12SchoolImprovement
    {
        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// School Improvement Funds Status
        /// <para>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19238">School Improvement Funds Status</a>
        /// </para>
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        public Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// School Improvement Exit Date
        /// <para>
        /// Date the school exited school improvement status.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19472">School Improvement Exit Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? SchoolImprovementExitDate { get; set; }

    }
}
