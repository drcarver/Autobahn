//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffEvaluationPartModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluationPartModel Interface
     /// </summary>
    public partial interface IStaffEvaluationPartModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.PartName non nullable property
        /// </summary>
        System.String PartName { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.Scale non nullable property
        /// </summary>
        System.String Scale { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.ScoreOrRating non nullable property
        /// </summary>
        System.String ScoreOrRating { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEvaluation"/> model
        /// </summary>
        Guid? StaffEvaluationId { get; set; }

    }
}
