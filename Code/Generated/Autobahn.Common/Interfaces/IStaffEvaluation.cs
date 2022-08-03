//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffEvaluation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluation
     /// </summary>
    public partial interface IStaffEvaluation
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

        /// <summary>
        /// Defines the StaffEvaluation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.RecordEndDateTime nullable property
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
