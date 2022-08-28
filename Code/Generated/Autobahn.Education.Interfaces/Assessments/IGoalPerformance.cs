//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalPerformance.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IGoalPerformance Interface
     /// </summary>
    public partial interface IGoalPerformance : IAutobahnBase
    {
        #region IGoalPerformance
        /// <summary>
        /// Goal Current Performance Description
        /// <para>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20671">Goal Current Performance Description</a>
        /// </para>
        /// </summary>
        System.String CurrentPerformanceDescription { get; set; }

        DateTime? Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Goal Status Type
        /// <para>
        /// Status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
        /// </para>
        /// </summary>
        Guid? RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// Goal Status
        /// <para>
        /// Description of status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20684">Goal Status</a>
        /// </para>
        /// </summary>
        System.String Status { get; set; }

        #endregion
    }
}
