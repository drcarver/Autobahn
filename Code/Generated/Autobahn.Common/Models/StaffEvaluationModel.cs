//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluation Model
     /// </summary>
    public partial class StaffEvaluationModel : AutobahnBase, Interfaces.IStaffEvaluation
    {
        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String Outcome { get; set; }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get; set; }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String Scale { get; set; }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String ScoreOrRating { get; set; }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String System { get; set; }

    }
}
