//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffEvaluationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluationModel Interface
     /// </summary>
    public partial interface IStaffEvaluationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.System non nullable property
        /// </summary>
        System.String System { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.Scale non nullable property
        /// </summary>
        System.String Scale { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.ScoreOrRating non nullable property
        /// </summary>
        System.String ScoreOrRating { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.Outcome non nullable property
        /// </summary>
        System.String Outcome { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevel"/> model
        /// </summary>
        Guid? RefStaffPerformanceLevelId { get; set; }

    }
}
