//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceModel.cs
//* Name:       Goal Current Performance Description
//* Definition: Current performance explanation related to the annual goal or short-term objectives.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// Current performance explanation related to the annual goal or short-term objectives.
     /// </summary>
    public partial class GoalPerformanceModel : AutobahnBase, Interfaces.IGoalPerformance
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
        public System.String CurrentPerformanceDescription { get; set; }

        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusType"/> model
        /// </summary>
        public Guid? RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// Goal Status
        /// <para>
        /// Description of status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20684">Goal Status</a>
        /// </para>
        /// </summary>
        public System.String Status { get; set; }

    }
}
