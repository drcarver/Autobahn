//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationPart.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluationPart
     /// </summary>
    public partial class StaffEvaluationPart : IStaffEvaluationPart
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.PartName non nullable property
        /// </summary>
        public System.String PartName { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.Scale non nullable property
        /// </summary>
        public System.String Scale { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.ScoreOrRating non nullable property
        /// </summary>
        public System.String ScoreOrRating { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEvaluation"/> model
        /// </summary>
        public Guid? StaffEvaluationId { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEvaluationPart.RecordEndDateTime nullable property
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
