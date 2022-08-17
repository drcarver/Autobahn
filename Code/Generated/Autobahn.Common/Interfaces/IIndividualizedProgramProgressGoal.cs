//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramProgressGoal.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressGoal Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressGoal : IAutobahnBase
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
        Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
        /// </summary>
        Guid IndividualizedProgramProgressReportId { get; set; }

    }
}
