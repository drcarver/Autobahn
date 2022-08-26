//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoal.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IGoal Interface
     /// </summary>
    public partial interface IGoal : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Goal End Date
        /// <para>
        /// The date on which the goal expires or has been achieved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20170">Goal End Date</a>
        /// </para>
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Goal Start Date
        /// <para>
        /// The date on which the goal becomes active.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20169">Goal Start Date</a>
        /// </para>
        /// </summary>
        DateTime? StartDate { get; set; }

    }
}
