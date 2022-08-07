//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationPartModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluationPart Model
     /// </summary>
    public partial class StaffEvaluationPartModel : AutobahnBase, Interfaces.IStaffEvaluationPartModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
