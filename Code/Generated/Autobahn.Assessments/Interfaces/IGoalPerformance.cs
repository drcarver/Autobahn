//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalPerformance.cs
//* Name:       Goal Current Performance Description
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IGoalPerformance : IAutobahnBase
    {
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

        System.DateTime? Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefGoalStatusType"/> model
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

    }
}
