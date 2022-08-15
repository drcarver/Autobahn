//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEvaluation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluation Interface
     /// </summary>
    public partial interface IStaffEvaluation : IAutobahnBase
    {
        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        System.String Outcome { get; set; }

    }
}
