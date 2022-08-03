//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffEvaluationPart.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluationPart
     /// </summary>
    public partial interface IStaffEvaluationPart
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

        /// <summary>
        /// Defines the StaffEvaluationPart.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
