//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The GoalPerformance Model
     /// </summary>
    public partial class GoalPerformanceModel : AutobahnBase, IGoalPerformance
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

        public DateTime? Date { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Goal Status Type
        /// <para>
        /// Status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
        /// </para>
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
