//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluation
     /// </summary>
    public partial class StaffEvaluation : IStaffEvaluation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.System non nullable property
        /// </summary>
        public System.String System { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.Scale non nullable property
        /// </summary>
        public System.String Scale { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.ScoreOrRating non nullable property
        /// </summary>
        public System.String ScoreOrRating { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.Outcome non nullable property
        /// </summary>
        public System.String Outcome { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevel"/> model
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEvaluation.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}