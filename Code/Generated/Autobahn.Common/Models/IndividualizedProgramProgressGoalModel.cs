//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressGoalModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal Model
     /// </summary>
    public partial class IndividualizedProgramProgressGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressGoal
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
        public Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportId { get; set; }

    }
}
