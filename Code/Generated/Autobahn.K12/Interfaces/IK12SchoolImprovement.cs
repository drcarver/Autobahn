//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolImprovement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolImprovement Interface
     /// </summary>
    public partial interface IK12SchoolImprovement : IAutobahnBase
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
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// School Improvement Funds Status
        /// <para>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19238">School Improvement Funds Status</a>
        /// </para>
        /// </summary>
        Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// School Improvement Exit Date
        /// <para>
        /// Date the school exited school improvement status.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19472">School Improvement Exit Date</a>
        /// </para>
        /// </summary>
        System.DateTime? SchoolImprovementExitDate { get; set; }

    }
}
